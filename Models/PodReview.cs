using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NespressoReviewsApi.Models
{
    public class PodReview : Review
    {
        public Guid PodId { get; set; }
        
        [ForeignKey("PodId")]
        public Pod Pod { get; set; }
    }
}