using System;
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
        [Required]
        public string UserName { get; set; }
        public string Bio { get; set; }
        
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        public ICollection<PodReview> PodReview { get; set; }

    }
}