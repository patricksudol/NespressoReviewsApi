using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.UserName = userForRegisterDto.UserName.ToLower();
            userForRegisterDto.EmailAddress = userForRegisterDto.EmailAddress.ToLower();

            if (await _repo.UserExists(userForRegisterDto.UserName))
                return BadRequest("Username already exists");
            
            var userToCreate = new User{
                UserName = userForRegisterDto.UserName,
                EmailAddress = userForRegisterDto.EmailAddress,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}