using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NespressoReviewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypesController : ControllerBase
    {
        [HttpGet, Authorize]
        public IEnumerable<string>Get()
        {
            return new string[] {"Original", "Vertuo"};
        }
    }
}