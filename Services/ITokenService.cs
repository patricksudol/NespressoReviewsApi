using System.Collections.Generic;
using System.Security.Claims;

namespace NespressoReviewsApi.Services
{
    public interface ITokenService
    {
         string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}