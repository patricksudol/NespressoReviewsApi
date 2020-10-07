using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NespressoReviewsApi.Models
{
    public class Pod : Reviewable
    {
        public CupSize CupSize { get; set; }
        public Guid CupSizeId { get; set; }

        public PodType PodType { get; set; }
        public Guid PodTypeId { get; set; }
    }
}