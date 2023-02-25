using System.ComponentModel.DataAnnotations;

namespace groupassignment.Models
{
    public class AddUserAccountModel
    {
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords need to match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DataType(DataType.Password)]
        public string Email { get; set; }
    }
}
