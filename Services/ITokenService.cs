using System.Collections.Generic;
using System.Security.Claims;

namespace NespressoReviewsApi.Services
{
    public interface ITokenService
    {
         string GenerateAccessToken(Claim[] claims);
         string GenerateRefreshToken();
         ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}