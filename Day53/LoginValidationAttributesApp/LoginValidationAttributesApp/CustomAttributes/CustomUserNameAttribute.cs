using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace LoginValidationAttributesApp.CustomAttributes
{
    public class CustomUserNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string username = value.ToString();

                if (Regex.IsMatch(username, @"^[a-zA-Z@]{7,15}$") && username.EndsWith("@rrd"))
                {
                    return ValidationResult.Success;
                }

                else
                {
                    return new ValidationResult("Username must ends with @rrd only Alphabets and between 7 to 15 characters.");
                }
            }
            return new ValidationResult("UserName is Required");//default error msg will get from Html helpers also
        }
    }
}
