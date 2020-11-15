using System;

namespace NespressoReviewsApi.Dtos
{
    public class PodReviewForListDto
    {
        public Guid Id { get; set; }
        public Guid PodId { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
    }
}