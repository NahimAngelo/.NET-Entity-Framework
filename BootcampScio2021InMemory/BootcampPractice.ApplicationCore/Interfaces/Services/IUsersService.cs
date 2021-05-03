using BootcampPractice.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BootcampPractice.ApplicationCore.Interfaces.Services
{
    public interface IUsersService
    {
        Task<User> CreateUser(User user);
        Task<IEnumerable<User>> GetAll();
        Task<User> FindUser(string id);
        void DeleteUser(string id);
    }
}
