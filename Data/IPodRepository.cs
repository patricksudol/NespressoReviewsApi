using System.Collections.Generic;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public interface IPodRepository : IRepositoryBase<Pod>
    {
         IEnumerable<Pod> GetPods();
    }
}