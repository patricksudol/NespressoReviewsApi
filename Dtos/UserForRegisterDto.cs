using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}