using System;

namespace NespressoReviewsApi.Models
{
    public abstract class Review : BaseModel
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        
        public int Score { get; set; }
        public string Description { get; set; }
    }
}