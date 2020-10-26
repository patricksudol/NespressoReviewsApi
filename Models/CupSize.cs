using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Models
{
    public class CupSize : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Volume { get; set; }

        public ICollection<Pod> Pod { get; set; }
    }
}