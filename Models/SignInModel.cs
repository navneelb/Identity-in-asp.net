using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
  
        public class SignInModel
        {
            [Required(ErrorMessage = "Please enter your email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please enter your password")]
            [DataType(DataType.Password)]
            public string PassWord { get; set; }

            [DisplayName("Remember Me")]
            public bool RememberMe { get; set; }
        }
    
}
