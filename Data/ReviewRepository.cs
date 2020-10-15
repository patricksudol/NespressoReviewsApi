using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public DataContext DataContext
        {
            get { return DataContext as DataContext; }
        }

        public ReviewRepository(DataContext context) : base(context) { }

        public IEnumerable<Review> GetReviewsByPod(Guid id)
        {
            return DataContext.Reviews.Where(r => r.Pod.Id == id);
        }

        public IEnumerable<Review> GetReviewsByUser(Guid id)
        {
            return DataContext.Reviews.Where(r => r.User.Id == id);
        }
    }
}