using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodReviewRepository : RepositoryBase<PodReview>, IPodReviewRepository
    {
        public DataContext DataContext
        {
            get { return DataContext as DataContext; }
        }

        public PodReviewRepository(DataContext context) : base(context) { }

        public IEnumerable<PodReview> GetReviewsByPod(Guid id)
        {
            return DataContext.PodReviews.Where(p => p.Pod.Id == id);
        }
        
        public IEnumerable<PodReview> GetReviewsByUser(Guid id)
        {
            return DataContext.PodReviews.Where(p => p.User.Id == id);
        }
    }
}