using System;
using System.Collections.Generic;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
         IEnumerable<Review> GetReviewsByPod(Guid id);

         IEnumerable<Review> GetReviewsByUser(Guid id);
    }
}