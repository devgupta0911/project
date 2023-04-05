using Microsoft.AspNetCore.Mvc;
using POC.Core.Domain;
using POC.Core.Interfaces;

namespace POC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _UserRepository;
        public UserController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        [HttpGet("UserID")]
        [ProducesResponseType(200, Type = typeof(User))]
        public IActionResult GetUserById(int UserID)
        {
            var user = _UserRepository.GetUserById(UserID); 

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(user);
        }

        [HttpGet("GetAllEmployee")]
        [ProducesResponseType(200, Type= typeof(IEnumerable<User>))]
        public IActionResult GetAll()
        {
            var all = _UserRepository.GetAll();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(all);
        }
    }
}
