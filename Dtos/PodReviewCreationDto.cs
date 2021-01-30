using System;
using System.ComponentModel.DataAnnotations;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Dtos
{
    public class PodReviewCreationDto : CreationDtoBase
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Score must be between 1 and 5")]
        public int Score { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid PodId { get; set; }
        PodReviewCreationDto() : base() {}
    }
}