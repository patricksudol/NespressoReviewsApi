using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Models
{
    public abstract class Reviewable : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public string Description { get; set; }
    }
}