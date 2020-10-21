using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodTypeRepository : RepositoryBase<PodType>, IPodTypeRepository
    {
        public DataContext DataContext
        {
            get { return DataContext as DataContext; }
        }

        public PodTypeRepository(DataContext context) : base(context) { }
    }
}