using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using BootcampPractice.ApplicationCore.Interfaces.Services;
using BootcampPractice.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BootcampPractice.ApplicationCore.Services
{
    public class UserService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        public async Task<User> CreateUser(User user)
        {
            var domainModelUser = new DomainModels.User { 
                Email = user.Email, 
                Name = user.Name 
            };
            var userData = await _usersRepository.Create(domainModelUser);
            return new User { Id = userData.Id, Email = userData.Email, Name = userData.Name };
        }

        public void DeleteUser(string id)
        {
            this._usersRepository.Delete(id);
        }

        public async Task<User> FindUser(string id)
        {
            var usersData = await this._usersRepository.GetById(id);
            return new User { Id = usersData.Id, Email = usersData.Email, Name = usersData.Name };
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var usersData = await this._usersRepository.GetAll();
            return usersData.Select(x => new User { Id = x.Id, Email = x.Email, Name = x.Name });
        }
    }
}
