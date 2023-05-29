using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UiDevelopmentWeb.Models
{
    public class LoginModel
    {
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        public string gender { get; set; }

        [Key]
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string zipcode { get; set; }

        [Required]
        public string country { get; set; }
        [NotMapped]
        public IFormFile profilePicture { get; set;}
        public string intrest { get; set; }
    }
}
