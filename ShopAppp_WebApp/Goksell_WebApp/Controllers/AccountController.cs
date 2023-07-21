using BusinessLayer.Abstract;
using Goksell_WebApp.Extensions;
using Goksell_WebApp.Identity;
using Goksell_WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Goksell_WebApp.Controllers
{
    [AutoValidateAntiforgeryToken]

    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private ICartService _cartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _cartService = cartService;
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var user =await _userManager.FindByNameAsync(loginModel.UserName);
            
            if(user == null)
            {
                ModelState.AddModelError("","Bu kullanıcı Adı ile daha once hesap oluşturulmamış");
                return View(loginModel);
            }


            var result = await _signInManager.PasswordSignInAsync(user,loginModel.Password,true,false);

            if (result.Succeeded)
            {
                return Redirect(loginModel.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("","Girilen parola veya kullanıcı adı yanlıştır.");
            return View(loginModel);
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName,
                Email=model.Email
            };

            var result =await _userManager.CreateAsync(user,model.Password);
            System.Console.WriteLine(result);
            if (result.Succeeded)
            {
                //generate token
                var code=await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("confirmEmail", "Account", new
                {
                    userId=user.Id,
                    token=code
                });
                System.Console.WriteLine(url);

                //cart objesi
                _cartService.InitializeCart(user.Id);
                return RedirectToAction("Login", "Account");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View(model);
            }
           
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return View();
            }
            var user =await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return View();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);


            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            TempData.Put("message", new AlertMessage()
            {
                Title="Oturum Sonlandırıldı",
                Message="Hesabınız güvenli şekilde kapatıldı.",
                AlertType="warning"
            });
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string UserId,string token)
        {
            if(UserId==null || token == null)
            {
                TempData.Put("message",new AlertMessage()
                {
                    Title="Geçersiz Token",
                    Message="Geçersiz Token",
                    AlertType="danger",
                });

            }

            var user = await _userManager.FindByIdAsync(UserId);

            if (user != null)
            {

                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Hesabınız Onaylandı.",
                        Message = "Hesabınız Onaylandı.",
                        AlertType = "success",
                    });

                    return View();
                }
                
            }

            TempData.Put("message", new AlertMessage()
            {
                Title = "Hesabınız onaylanmadı",
                Message = "Hesabınız onaylanmadı",
                AlertType = "warning",
            });



            return View();
        }

        public IActionResult AccesDenied()
        {
            return View();
        }

        


    }
}
