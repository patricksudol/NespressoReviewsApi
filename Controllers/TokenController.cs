using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Models;
using NespressoReviewsApi.Services;

namespace NespressoReviewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        readonly DataContext userContext;
        readonly ITokenService tokenService;
        
        public TokenController(DataContext userContext, ITokenService tokenService)
        {
            this.userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
            this.tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }
        
        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh(Token tokenModel)
        {
            if (tokenModel is null)
            {
                return BadRequest("Invalid client request");
            }
            string accessToken = tokenModel.AccessToken;
            string refreshToken = tokenModel.RefreshToken;
            var principal = tokenService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity.Name;
            var user = userContext.Users.SingleOrDefault(u => u.UserName == username);
            
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest("Invalid client request");
            
            var newAccessToken = tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = tokenService.GenerateRefreshToken();
            
            user.RefreshToken = newRefreshToken;
            userContext.SaveChanges();
            return new ObjectResult(new
            {
                accessToken = newAccessToken,
                refreshToken = newRefreshToken
            });
        }
        
        
        [HttpPost, Authorize]
        [Route("revoke")]
        public IActionResult Revoke()
        {
            var username = User.Identity.Name;
            var user = userContext.Users.SingleOrDefault(u => u.UserName == username);
            if (user == null)
                return BadRequest();
            user.RefreshToken = null;
            userContext.SaveChanges();
            return NoContent();
        }
    }
}