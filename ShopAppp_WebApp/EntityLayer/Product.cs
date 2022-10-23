using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Ürün ismi için 10-60 karakter arasında giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fiyat girmelisiniz.")]
        [Range(1, 100000)]
        public string Url { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
    
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
