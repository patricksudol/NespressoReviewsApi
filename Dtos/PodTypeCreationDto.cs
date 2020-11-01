namespace NespressoReviewsApi.Dtos
{
    public class PodTypeCreationDto : CreationDtoBase
    {
        public PodTypeCreationDto() : base() {}
        
        public string Name { get; set; }
        public int Order { get; set; }
    }
}