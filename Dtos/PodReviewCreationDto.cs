using System;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Dtos
{
    public class PodReviewCreationDto : CreationDtoBase
    {
        public User User { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public Guid PodId { get; set; }
        PodReviewCreationDto() : base() {}
    }
}