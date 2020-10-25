using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;

namespace NespressoReviewsApi.Controllers
{
    public abstract class BaseController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IRepositoryBase<TModel>
    {
        protected readonly TRepository Repository;

        public BaseController(TRepository repository)
        {
            this.Repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TModel>> GetInstance(Guid id)
        {
            try
            {
                var result = Repository.Get(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Test");
            }
        }

        
        [HttpGet]
        public IEnumerable<TModel> GetAll()
        {
            return Repository.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] TModel item)
        {
            Repository.Create(item);
        }
    }
}