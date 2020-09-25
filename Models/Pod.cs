using System;

namespace NespressoReviewsApi.Models
{
    public class Pod : Reviewable
    {
        public Type Type { get; set; }
        public Guid TypeId { get; set; }
    }
}