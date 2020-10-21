using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NespressoReviewsApi.Models
{
    public class PodReview : Review
    {
        public Pod Pod { get; set; }
        public Guid PodId { get; set; }
    }
}