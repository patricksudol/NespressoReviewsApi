using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : BaseController<Review, ReviewRepository>
    {
        public ReviewsController(ReviewRepository reviewRepository) : base (reviewRepository) { }

        [HttpGet("{id}")]
        public IEnumerable<Review> ByPod(Guid id)
        {
            return base.Repository.GetReviewsByPod(id);
        }

        [HttpGet("{id}")]
        public IEnumerable<Review> ByUsser(Guid id)
        {
            return base.Repository.GetReviewsByUser(id);
        }
    }
}