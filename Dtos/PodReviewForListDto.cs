using System;

namespace NespressoReviewsApi.Dtos
{
    public class PodReviewForListDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PodId { get; set; }
        public int Score { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}