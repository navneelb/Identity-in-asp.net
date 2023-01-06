using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee First Name")]       
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Employee Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Employee Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Employee Phone")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Employee Address")]
        public string Adderss { get; set; }
    }
}
