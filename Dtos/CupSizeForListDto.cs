using System;

namespace NespressoReviewsApi.Dtos
{
    public class CupSizeForListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Volume { get; set; }
    }
}