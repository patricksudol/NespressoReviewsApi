using System;
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
        public async Task<IActionResult> GetPodReviews()
        {
            var podreviews = _repo.GetAll();
            return Ok(podreviews);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPodReview(Guid id)
        {
            return Ok(_repo.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePodReview(PodReviewCreationDto podReviewCreationDto)
        {
            var podReviewsToCreate = new PodReview
            {
                User = podReviewCreationDto.User,
                Score = podReviewCreationDto.Score,
                Description = podReviewCreationDto.Description,
                PodId = podReviewCreationDto.PodId
            };
            _repo.Create(podReviewsToCreate);

            return StatusCode(201);
        }
    }
}