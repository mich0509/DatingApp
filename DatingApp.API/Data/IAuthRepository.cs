using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task <User> Register(User user, string password);
         Task <User> Login(User user, string password);
         Task <bool> UserExist(string username);
        Task Login(string username, string password);
    }
}