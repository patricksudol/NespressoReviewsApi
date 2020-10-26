using System.Collections.Generic;

namespace NespressoReviewsApi.Models
{
    public class PodType : BaseModel
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public ICollection<Pod> Pod { get; set; }
    }
}