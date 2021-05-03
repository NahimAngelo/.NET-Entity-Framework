using BootcampPractice.ApplicationCore.DomainModels;
using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BootcampPractice.Infrastructure.Data
{
    public class UserRepository : IUsersRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public async Task<User> Create(User user)
        {
            var userId = Guid.NewGuid();
            await _context.Users.AddAsync(new Model.User() { Id = userId, Email = user.Email, Name = user.Name });
            _context.SaveChanges();
            user.Id = userId.ToString();
            return user;
        }

        public void Delete(string id)
        {
            var idGuid = Guid.Parse(id);
            var user = _context.Users.Find(idGuid);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            var users = _context.Users.Select(x => new User() { Id = x.Id.ToString(), Email = x.Email, Name = x.Name });
            return Task.FromResult((IEnumerable<User>)users);
        }

        public Task<User> GetById(string id)
        {
            var idGuid = Guid.Parse(id);
            var user = _context.Users.Find(idGuid);
            return Task.FromResult(new User() { Id = user.Id.ToString(), Email = user.Email, Name = user.Name });
        }
    }
}
