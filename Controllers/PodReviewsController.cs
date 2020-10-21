using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PodReviewsController : BaseController<PodReview, PodReviewRepository>
    {
        public PodReviewsController(PodReviewRepository podReviewRepository) : base(podReviewRepository) { }

        [HttpGet("pod/{id}")]
        public IEnumerable<PodReview> ByPod(Guid id)
        {
            return base.Repository.GetReviewsByPod(id);
        }

        [HttpGet("user/{id}")]
        public IEnumerable<PodReview> ByUser(Guid id)
        {
            return base.Repository.GetReviewsByUser(id);
        }
    }
}