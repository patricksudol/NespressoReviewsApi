using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodReviewRepository : IBaseRepository<PodReview>
    {
        private readonly DataContext _context;
        public PodReviewRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(PodReview entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(PodReview entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public PodReview Get(Guid Id)
        {
            return _context.Set<PodReview>().Find(Id);
        }

        public IEnumerable<PodReview> GetByUser(Guid userId)
        {
            return _context.Set<PodReview>().Where(p => p.UserId == userId);
        }

        public IEnumerable<PodReview> GetByPod(Guid podId)
        {
            return _context.Set<PodReview>().Where(p => p.PodId == podId);
        }

        public IEnumerable<PodReview> GetAll()
        {
            return _context.Set<PodReview>().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}