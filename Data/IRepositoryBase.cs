using System;
using System.Collections.Generic;

namespace NespressoReviewsApi.Data
{
    public interface IRepositoryBase<TModel> where TModel : class
    {
        TModel Get(Guid Id);
        IEnumerable<TModel> GetAll();
        void Create(TModel entity);
        void Update(TModel entity);
        void Delete(TModel entity);
    }
}