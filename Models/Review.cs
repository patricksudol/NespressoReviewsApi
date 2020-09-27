using System;

namespace NespressoReviewsApi.Models
{
    public class Review : BaseModel
    {
        public User User { get; set; }
        public Guid UserId { get; set; }   
        public int Score { get; set; }
        public string Description { get; set; }
    }
}