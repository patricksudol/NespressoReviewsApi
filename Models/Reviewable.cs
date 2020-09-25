namespace NespressoReviewsApi.Models
{
    public abstract class Reviewable : BaseModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}