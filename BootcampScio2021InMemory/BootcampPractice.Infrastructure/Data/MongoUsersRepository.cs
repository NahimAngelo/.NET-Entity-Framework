using BootcampPractice.ApplicationCore.DomainModels;
using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BootcampPractice.Infrastructure.Data
{
    public class MongoUsersRepository : IUsersRepository
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
