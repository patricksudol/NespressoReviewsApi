using System;
using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Models
{
    public class PodReview : BaseModel
    {
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public Guid PodId { get; set; }
        public Pod Pod { get; set; }
        
        [Required]
        [Range(1, 5, ErrorMessage = "Score must be between 1 and 5")]
        public int? Score { get; set; }
        public string Description { get; set; }
    }
} 
