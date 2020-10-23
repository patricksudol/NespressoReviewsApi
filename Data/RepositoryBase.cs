using System;
using System.Collections.Generic;
using System.Linq;

namespace NespressoReviewsApi.Data
{
    public abstract class RepositoryBase<TModel> : IRepositoryBase<TModel> where TModel : class
    {
        protected DataContext DataContext{ get; set; }

        public RepositoryBase(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public TModel Get(Guid id)
        {
            return DataContext.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return DataContext.Set<TModel>().ToList();
        }

        public void Create(TModel entity)
        {
            this.DataContext.Set<TModel>().Add(entity);
        }

        public void Update(TModel entity)
        {
            this.DataContext.Set<TModel>().Remove(entity);
        }

        public void Delete(TModel entity)
        {
            this.DataContext.Set<TModel>().Remove(entity);
        }
    }
}