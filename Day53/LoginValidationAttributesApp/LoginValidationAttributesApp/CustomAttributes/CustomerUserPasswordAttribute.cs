using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LoginValidationAttributesApp.CustomAttributes
{
    public class CustomerUserPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string password = value.ToString();
                if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{5,15}$"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Password must be at least 5 characters long, contain at least one uppercase letter, one lowercase letter,one special character, and one digit.");
                }
            }
            return new ValidationResult("Password is required");//default error msg will get from Html helpers also

        }
    }
}