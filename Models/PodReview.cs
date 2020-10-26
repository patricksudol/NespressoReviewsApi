using System;

namespace NespressoReviewsApi.Models
{
    public class PodReview : Review
    {
        public Pod Pod { get; set; }
    }
}