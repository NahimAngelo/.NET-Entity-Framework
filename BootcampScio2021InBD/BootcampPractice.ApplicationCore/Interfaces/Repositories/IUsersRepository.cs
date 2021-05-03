using BootcampPractice.ApplicationCore.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BootcampPractice.ApplicationCore.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        Task<User> Create(User user);
        void Delete(string id);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(string id);

    }
}
