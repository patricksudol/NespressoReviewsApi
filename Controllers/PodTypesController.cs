using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PodTypesController : BaseController<PodType, PodTypeRepository>
    {
        public PodTypesController(PodTypeRepository podTypeRepository) : base(podTypeRepository) { }
    }
}