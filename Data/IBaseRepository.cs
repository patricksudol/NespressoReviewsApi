using System;
using System.Collections.Generic;

namespace NespressoReviewsApi.Data
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(Guid Id);
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}