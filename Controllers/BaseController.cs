using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;

namespace NespressoReviewsApi.Controllers
{
    public abstract class BaseController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IRepository<TModel>
    {
        protected readonly TRepository Repository;

        public BaseController(TRepository repository)
        {
            this.Repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<TModel> Get()
        {
            return Repository.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] TModel item)
        {
            Repository.Add(item);
        }
    }
}