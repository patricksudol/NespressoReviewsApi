using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Models
{
    public class User : BaseModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        public ICollection<PodReview> PodReview { get; set; }

    }
}