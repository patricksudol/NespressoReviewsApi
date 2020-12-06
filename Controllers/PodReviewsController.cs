using System;
using System.Collections.Generic;
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
    public class PodReviewsController : ControllerBase
    {
        private readonly PodReviewRepository _repo;
        private readonly IMapper _mapper;
        public PodReviewsController(PodReviewRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPodReviews(Guid userId, Guid podId)
        {
            var podReviews = _repo.GetAll();
            if (!(userId == Guid.Empty))
                podReviews = _repo.GetByUser(userId);
            if (!(podId == Guid.Empty))
                podReviews = _repo.GetByPod(podId);
            return Ok(_mapper.Map<IEnumerable<PodReviewForListDto>>(podReviews));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPodReview(Guid id)
        {
            return Ok(_repo.Get(id));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePodReview(PodReviewCreationDto podReviewCreationDto)
        {
            var podReviewsToCreate = new PodReview
            {
                UserId = podReviewCreationDto.UserId,
                Score = podReviewCreationDto.Score,
                Description = podReviewCreationDto.Description,
                PodId = podReviewCreationDto.PodId
            };
            _repo.Create(podReviewsToCreate);

            return StatusCode(201);
        }
    }
}