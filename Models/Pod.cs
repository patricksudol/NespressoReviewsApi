using System;
using System.Collections.Generic;

namespace NespressoReviewsApi.Models
{
    public class Pod : Reviewable
    {
        public CupSize CupSize { get; set; }
        public PodType PodType { get; set; }

        public ICollection<PodReview> PodReview { get; set; }
    }
}