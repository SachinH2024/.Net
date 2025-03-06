namespace AjaxCallEmailValidation.Services
{
    public interface IRegisterService
    {
        bool IsEmailExists(string email);
    }
}

