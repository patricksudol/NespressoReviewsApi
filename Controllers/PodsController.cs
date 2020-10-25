using System;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PodsController : BaseController<Pod, PodRepository>
    {
        public PodsController(PodRepository podRepository) : base (podRepository) { }
    }
}