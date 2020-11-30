using System.ComponentModel.DataAnnotations;

namespace NespressoReviewsApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}