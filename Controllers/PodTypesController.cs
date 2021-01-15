using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodTypesController : ControllerBase
    {
        private readonly PodTypeRepository _repo;
        private readonly IMapper _mapper;
        public PodTypesController(PodTypeRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPodTypes()
        {
            var podTypes = _repo.GetAll();
            return Ok(_mapper.Map<IEnumerable<PodTypeForListDto>>(podTypes));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPodType(Guid id)
        {
            var podType = _repo.Get(id);
            return Ok(_mapper.Map<PodTypeForListDto>(podType));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePodType(PodTypeCreationDto podTypeCreationDto)
        {
            var podTypeToCreate = new PodType
            {
                Name = podTypeCreationDto.Name,
                Order = podTypeCreationDto.Order
            };

            _repo.Create(podTypeToCreate);

            return StatusCode(201);
        }
    }
}