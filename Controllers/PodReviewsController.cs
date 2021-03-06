using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NespressoReviewsApi.Data;
using NespressoReviewsApi.Dtos;
using NespressoReviewsApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace NespressoReviewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodReviewsController : ControllerBase
    {
        private readonly PodReviewRepository _repo;
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        // TODO: Has to be null for non authorized requests
        // private readonly Guid _userId;

        public PodReviewsController(DataContext context, PodReviewRepository repo, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _repo = repo;
            _httpContextAccessor = httpContextAccessor;
            // _userId = new Guid(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            var podReview = _repo.Get(id);
            return Ok(_mapper.Map<PodReviewForListDto>(podReview));
        }

        [HttpGet("{podId}/average")]
        public async Task<IActionResult> GetPodReviewAverage(Guid podId)
        {
            var podReviews = _repo.GetByPod(podId);
            var scoreSum = 0;
            foreach (var podReview in podReviews)
            {
                scoreSum += podReview.Score;
            }
            var averageDouble = podReviews.Count() > 0 ? scoreSum/(double)podReviews.Count() : 0;
            return Ok(averageDouble.ToString("0.0"));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePodReview(PodReviewCreationDto podReviewCreationDto)
        {
            var podReviewsToCreate = new PodReview
            {
                UserId = new Guid(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)),
                Score = podReviewCreationDto.Score,
                Header = podReviewCreationDto.Header,
                Description = podReviewCreationDto.Description,
                PodId = podReviewCreationDto.PodId,
                CreatedDate = podReviewCreationDto.CreatedDate
            };
            _repo.Create(podReviewsToCreate);

            // TODO: Use 'Created()' method
            return StatusCode(201);
        }

        [Authorize]
        [HttpPatch("{id:Guid}")]
        public IActionResult PatchPodReview(Guid id, [FromBody] JsonPatchDocument<PodReview> patchEntity)
        {
            var entity = _repo.Get(id);
            var userId = new Guid(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (entity == null)
                return NotFound();

            if (entity.UserId != userId)
                return Forbid();


            patchEntity.ApplyTo(entity, ModelState);
            TryValidateModel(entity);
            if (!ModelState.IsValid)
                return StatusCode(403);

            entity.ModifiedDate = DateTime.Now;
            _repo.Save();

            return Ok(entity);
        }
    }
}
