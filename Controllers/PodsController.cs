using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;

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
        public async Task<IActionResult> GetPods(string podtype)
        {
            var pods = _repo.GetAll();
            if (!String.IsNullOrEmpty(podtype))
                pods = _repo.GetByPodType(podtype);
            return Ok(_mapper.Map<IEnumerable<PodForListDto>>(pods));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPod(Guid id)
        {
            return Ok(_repo.Get(id));
        }
    }
}