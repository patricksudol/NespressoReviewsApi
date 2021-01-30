using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class PodTypeRepository : IBaseRepository<PodType>
    {
        private readonly DataContext _context;
        public PodTypeRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(PodType entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(PodType entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public PodType Get(Guid Id)
        {
            return _context.Set<PodType>().Find(Id);
        }

        public IEnumerable<PodType> GetAll()
        {
            return _context.Set<PodType>().ToList();
        }
    }
}