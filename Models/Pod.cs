using System;

namespace NespressoReviewsApi.Models
{
    public class Pod : Reviewable
    {
        public Type Type { get; set; }
        public Guid TypeId { get; set; }

        public CupSize CupSize { get; set; }
        public Guid CupSizeId { get; set; }
    }
}