using CafeApplication.Database.Framework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeApplication.Api.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private DatabaseContext _context;
        public UserController(DatabaseContext context)
        {
           _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
    }
}
