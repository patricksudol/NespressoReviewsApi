using System.Collections.Generic;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public interface IPodRepository : IRepository<Pod>
    {
         IEnumerable<Pod> GetPods();
    }
}