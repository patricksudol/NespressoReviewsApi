using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;

namespace NespressoReviewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodsController : ControllerBase
    {
        private readonly PodRepository _repo;
        private readonly IMapper _mapper;
        public PodsController(PodRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPods()
        {
            var pods = _repo.GetAll();
            var podsToReturn = _mapper.Map<IEnumerable<PodForListDto>>(pods);
            return Ok(podsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPod(Guid id)
        {
            return Ok(_repo.Get(id));
        }
    }
}