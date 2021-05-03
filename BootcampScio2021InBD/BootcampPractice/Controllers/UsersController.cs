using BootcampPractice.ApplicationCore.Interfaces.Services;
using BootcampPractice.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            this._usersService = usersService;
        }

        [HttpPost]
        public Task<User> Create(User user)
        {
            return this._usersService.CreateUser(user);
        }

        [HttpGet]
        public Task<IEnumerable<User>> GetAll()
        {
            return this._usersService.GetAll();
        }

        [HttpGet, Route("{id}")]
        public Task<User> GetById([FromRoute] string id)
        {
            return this._usersService.FindUser(id);
        }

        [HttpDelete, Route("{id}")]
        public void Delete([FromRoute] string id)
        {
            this._usersService.DeleteUser(id);
        }
    }
}
