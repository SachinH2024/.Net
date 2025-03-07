using System.ComponentModel.DataAnnotations;

namespace MyBankApp.Models
{
    public class User
    {
        [Key]
        //public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } 

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        

        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        //public string Email { get; set; } //Optional for signup

        //public string? Name { get; set; }
    }
}
