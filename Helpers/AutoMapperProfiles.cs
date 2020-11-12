using AutoMapper;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PodType, PodTypeCreationDto>();
            CreateMap<PodReview, PodReviewCreationDto>();
            // CreateMap<PodReview, PodReviewForListDto>();
        }
    }
}