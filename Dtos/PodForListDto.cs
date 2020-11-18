using System;

namespace NespressoReviewsApi.Dtos
{
    public class PodForListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public Guid CupSizeId { get; set; }
        public Guid PodTypeId { get; set; }
    }
}