using EntityLayer;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goksell_WebApp.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        /*[Display(Prompt ="Enter a product name")]
        [Required(ErrorMessage ="Ad zorunlu bir alan")]
        [StringLength(60,MinimumLength =5,ErrorMessage ="Ürün ismi 5 ile 10 karakter aralığında olmadır.")]
        */
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Url zorunlu bir alan")]

        public string Url { get; set; }
        
        /*[Required(ErrorMessage = "Fiyat zorunlu bir alan")]
        [Range(1,100000,ErrorMessage ="Fiyat için 1 ile 10000 arasında bir değer girmelisiniz")]*/
        public double? Price { get; set; }
        
        [Required(ErrorMessage = "Açıklama zorunlu bir alan")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Açıklama 5 ile 1000 karakter arasında olmalıdır.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Resim Yolu zorunlu bir alan")]
        
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
