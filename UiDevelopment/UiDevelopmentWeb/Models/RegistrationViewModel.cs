using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UiDevelopmentWeb.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        public string gender { get; set; }

        [Key]
        [Required, MaxLength(256)]
        public string email { get; set; }

        [Required, DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password), Compare(nameof(password))]
        public string comfirmPassword { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string zipcode { get; set; }

        [Required]
        public string country { get; set; }
        [NotMapped]
        public IFormFile profilePicture { get; set; }
        public string intrest { get; set; }
    }
}
