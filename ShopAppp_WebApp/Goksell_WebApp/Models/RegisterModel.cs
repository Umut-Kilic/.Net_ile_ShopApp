using System.ComponentModel.DataAnnotations;

namespace Goksell_WebApp.Models
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }
        
        
        [Required]
        public string LastName { get; set; }
        
        
        [Required]
        public string UserName { get; set; }
        
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifre tekrarı şifreniz ile aynı olmalıdır.")]
        public string RePassword { get; set; }
        
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
