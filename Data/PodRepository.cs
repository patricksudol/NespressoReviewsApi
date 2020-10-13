using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodRepository : RepositoryBase<Pod>, IPodRepository
    {
        public DataContext DataContext
        { 
            get { return DataContext as DataContext; }
        }

        public PodRepository(DataContext context) : base(context) { }

        public IEnumerable<Pod> GetPods()
        {
            return DataContext.Pods.ToList();
        }
    }
}