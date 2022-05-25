using ClientApi.Data;
using ClientApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _Context;

        public UsersController(DataContext context)
        {
            _Context = context; 
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _Context.Users.ToListAsync();
            
        }

        [HttpGet("{Id}")]
        public async Task <ActionResult<User>> GetUser(int Id)
        {
            return await _Context.Users.FindAsync(Id);
            ;
        }
    }
}
