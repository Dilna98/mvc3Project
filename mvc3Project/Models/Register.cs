using System.ComponentModel.DataAnnotations;

namespace mvc3Project.Models
{
    public class Register
    {
        [Key]
        public int Rid { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "name must bebetween 3 and 50 charectors")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Dte of birth is required")]
        [DataType(DataType.Date)]
       
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "passwored must be between 6 and 20 letters")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Type is requierd")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Status is requierd")]
        public string Status { get; set; }

    }
}

