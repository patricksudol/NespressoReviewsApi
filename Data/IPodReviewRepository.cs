using System;
using System.Collections.Generic;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public interface IPodReviewRepository : IRepositoryBase<PodReview>
    {
        IEnumerable<PodReview> GetReviewsByPod(Guid id);

        IEnumerable<PodReview> GetReviewsByUser(Guid id);
    }
}