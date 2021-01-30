using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodRepository : IBaseRepository<Pod>
    {
        private readonly DataContext _context;
        public PodRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Pod entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Pod entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Pod> GetByPodType(string podtype)
        {
            return _context.Set<Pod>().Where(p => p.PodType.Name == podtype);
        }

        public Pod Get(Guid Id)
        {
            return _context.Set<Pod>().Find(Id);
        }

        public IEnumerable<Pod> GetAll()
        {
            return _context.Set<Pod>().ToList();
        }
    }
}