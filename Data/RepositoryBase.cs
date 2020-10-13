using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace NespressoReviewsApi.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext DataContext{ get; set; }

        public RepositoryBase(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public T Get(Guid id)
        {
            return DataContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DataContext.Set<T>().ToList();
        }

        public void Create(T entity)
        {
            this.DataContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.DataContext.Set<T>().Remove(entity);
        }

        public void Delete(T entity)
        {
            this.DataContext.Set<T>().Remove(entity);
        }
    }
}