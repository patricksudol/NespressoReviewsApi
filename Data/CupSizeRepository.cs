using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class CupSizeRepository : IBaseRepository<CupSize>
    {
        private readonly DataContext _context;
        public CupSizeRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(CupSize entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(CupSize entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public CupSize Get(Guid Id)
        {
            return _context.Set<CupSize>().Find(Id);
        }

        public IEnumerable<CupSize> GetAll()
        {
            return _context.Set<CupSize>().ToList();
        }
    }
}