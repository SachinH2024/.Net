namespace LoginFormValidationInServersideUsingDB.Repository
{
    public interface IService
    {
        bool IsUserAvailable(string username);
    }
}
