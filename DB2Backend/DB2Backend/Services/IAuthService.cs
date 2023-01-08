using DB2Backend.Models;

namespace DB2Backend.Services
{
    public interface IAuthService
    {

        LoginResponse Login(string email, string password);
    }
}
