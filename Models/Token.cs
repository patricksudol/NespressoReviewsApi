namespace NespressoReviewsApi.Models
{
    public class Token : BaseModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}