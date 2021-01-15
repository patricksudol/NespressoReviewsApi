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
    public class CupSizeController : ControllerBase
    {
        private readonly CupSizeRepository _repo;
        private readonly IMapper _mapper;
        public CupSizeController(CupSizeRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCupSizes()
        {
            var cupSizes = _repo.GetAll();
            return Ok(_mapper.Map<IEnumerable<CupSizeForListDto>>(cupSizes));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCupSize(Guid id)
        {
            var cupSize = _repo.Get(id);
            return Ok(_mapper.Map<CupSizeForListDto>(cupSize));
        }
    }
}