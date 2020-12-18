using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Dtos
{
    public class UserResetPassword
    {
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}