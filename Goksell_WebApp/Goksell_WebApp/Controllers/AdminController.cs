using Business.Abstract;
using BusinessLayer.Abstract;
using EntityLayer;
using Goksell_WebApp.Identity;
using Goksell_WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Goksell_WebApp.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        public AdminController(IProductService productService,
            ICategoryService categoryService, 
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager)
        {
            _productService = productService;   
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult UserCreate()
        {
            return View();
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles =  _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId=user.Id,
                    FirstName=user.FirstName,
                    LastName=user.LastName,
                    UserName=user.UserName,
                    Email=user.Email,
                    EmailConfirmed=user.EmailConfirmed,
                    selectedRoles=selectedRoles
                });
            }
            return Redirect("~/amin/user/list");
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);

                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] {};
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());
                        return Redirect("/admin/user/list");
                    }
                }
                return View(model);
            }
            return View(model);
        }

            public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users.ToList())
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }

            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {

                foreach (var userId in model.IdsToAdd ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("",error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
                return Redirect("/admin/role/" + model.RoleId);


            }
            return View(model);


        }

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole() { Name=model.Name});
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",error.Description);
                    }
                }
            }
            return View(model);
        }



        public IActionResult ProductList()
        {
            return View(new ProductListViewModel()
            {
                Products = _productService.GetAll()
            }); ;
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel product)
        {
            if (ModelState.IsValid)
            {

            
                var entity = new Product()
                {
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Description = product.Description,
                    IsApproved = product.IsApproved,
                    IsHome = product.IsHome,
                    Name = product.Name,
                    Url = product.Url,
                };
                if (_productService.Create(entity))
                {
                    CreateMessage($"{entity.Name} aslı ürün eklendi","alert-success");
                    return RedirectToAction("ProductList");

                }
                CreateMessage(_productService.ErrorMessage, "alert-danger");

                return View(product);
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult productEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetByIdWithCategories((int)id);
            if (entity == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                ProductId=entity.ProductId,
                Name=entity.Name,
                ImageUrl=entity.ImageUrl,
                Url= entity.Url,
                Price= entity.Price,
                Description= entity.Description,
                SelectedCategories= entity.ProductCategories.Select(i=>i.Category).ToList(),
                IsHome = entity.IsHome,
                IsApproved=entity.IsApproved
            };

            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> productEdit(ProductModel productModel,int[] categoryIds,IFormFile file)
        {
            if (ModelState.IsValid)
            {

                Product product = _productService.GetByIdWithCategories(productModel.ProductId);

                if (product == null)
                {
                    return NotFound();
                }
                product.ProductId = productModel.ProductId; 
                product.Name = productModel.Name;
                product.Url = productModel.Url;
                product.Price = productModel.Price;
                product.Description = productModel.Description;
                product.IsApproved = productModel.IsApproved;
                product.IsHome = productModel.IsApproved;

                if (file != null)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                    
                    product.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);

                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                if (_productService.Update(product,categoryIds))
                {
                    CreateMessage($"{product.Name} aslı ürün güncellendi", "alert-success");
                    return RedirectToAction("ProductList");

                }
                CreateMessage(_productService.ErrorMessage, "alert-danger");


            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(productModel);
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetById((int)id);
            _productService.Delete(entity);

            var msg = new AlertMessage() {
                Message=$"{entity.Name} isimli ürün silinmiştir.",
                AlertType="alert-danger"
                };

            TempData["message"] = JsonConvert.SerializeObject(msg);  

            return RedirectToAction("ProductList");
        }

        public IActionResult categoryList()
        {
            var categories = _categoryService.GetAll();
            
            return View(categories);
        }

        [HttpGet] 
        public IActionResult categoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult categoryCreate(CategoryViewModel categoryModel)
        {
            if (ModelState.IsValid)
            {

                var entity = new Category()
                {
                    Name = categoryModel.Name,
                    Url = categoryModel.Url
                };

                _categoryService.Create(entity);

                var msg = new AlertMessage()
                {
                    Message = $"{categoryModel.Name} isimli Kategori eklenmiştir.",
                    AlertType = "alert-success"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("categoryList");


            }
            return View(categoryModel);
        }


        [HttpGet]
        public IActionResult categoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _categoryService.GetByIdWithProducts((int)id);

            if(category == null)
            {
                return NoContent();
            }

            var categoryModel = new CategoryViewModel()
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Url = category.Url,
                Products = category.ProductCategories.Select(pc => pc.Product).ToList()
            };

            return View(categoryModel);
        }

        [HttpPost]
        public IActionResult categoryEdit(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {

                var category = _categoryService.GetById(categoryViewModel.CategoryId);

                if (category == null)
                {
                    return NoContent();
                }

                category.Name = categoryViewModel.Name;
                category.Url = categoryViewModel.Url;
            
                _categoryService.Update(category);

                var msg = new AlertMessage()
                {
                    Message = $"{category.Name} isimli Kategori güncellenmiştir.",
                    AlertType = "alert-warning"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("categoryList");

            }
            return  View(categoryViewModel);
        }

        [HttpPost]
        public IActionResult categoryDelete(int? id,int productId)
        {
            if(id == null)
            {
                return NotFound();
            }
            var category = _categoryService.GetById((int)id);
            _categoryService.Delete(category);

            var msg = new AlertMessage()
            {
                Message = $"{category.Name} isimli Kategori silinmiştir.",
                AlertType = "alert-danger"
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("categoryList");
        }

        private void CreateMessage(string message,string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };

            TempData["message"] = JsonConvert.SerializeObject(msg);

        }
    }
}
