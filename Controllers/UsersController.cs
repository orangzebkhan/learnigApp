using ClientApi.Data;
using ClientApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientApi.Controllers
{
  
    public class UsersController : BaseApiController
    {
        private readonly DataContext _Context;

        public UsersController(DataContext context)
        {
            _Context = context; 
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task <ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _Context.Users.ToListAsync();
            
        }
        [Authorize]
        [HttpGet("{Id}")]
        public async Task <ActionResult<User>> GetUser(int Id)
        {
            return await _Context.Users.FindAsync(Id);
            ;
        }
    }
}
