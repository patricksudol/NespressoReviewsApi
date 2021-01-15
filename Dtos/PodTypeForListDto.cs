using System;

namespace NespressoReviewsApi.Dtos
{
    public class PodTypeForListDto
    {
        public Guid Id { get; set; }
        public string Name {get; set; }
        public int Order { get; set; }
    }
}