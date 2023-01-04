namespace DB2Backend.Services
{
    public interface IAuthService
    {

        int Login(string email, string password);
    }
}
