using System.ComponentModel.DataAnnotations;
namespace groupassignment.Models
{
    public class UserAccount
    {
        

        [Key]
        public Guid Userid { get; set; }

        [Required(ErrorMessage ="First Name is required")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public  string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is required")]
     
        public string Email { get; set; }

        public const string SessionKeyUsername = "SessionKeyUsername";
        public const string SessionKeyId = "SessionKeyId";





    }
}
