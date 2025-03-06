using System.ComponentModel.DataAnnotations;
using LoginValidationAttributesApp.CustomAttributes;

namespace LoginValidationAttributesApp.DTOs
{
    public class LoginDto
    {
        [CustomUserNameAttribute]
        public string UserName { get; set; }

        [CustomerUserPassword]
        public string UserPassword { get; set; }
    }
}
