using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;
using NespressoReviewsApi.Services;

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

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.Username.ToLower(), userForLoginDto.Password);

            if (userFromRepo == null)
                return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromRepo.UserName)
            };

            var tokenServices = new TokenService(_config);
            var token = tokenServices.GenerateAccessToken(claims);
            
            var refreshToken = tokenServices.GenerateRefreshToken();
            userFromRepo.RefreshToken = refreshToken;
            _repo.Save();

            return Ok(new {
                accesstoken = token,
                refreshtoken = refreshToken
            });
        }
    }
}
