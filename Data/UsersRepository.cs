using System;
using System.Collections.Generic;
using System.Linq;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class UsersRepository : IBaseRepository<User>
    {
        private readonly DataContext _context;
        public UsersRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(User entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(User entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public User Get(Guid Id)
        {
            return _context.Set<User>().Find(Id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Set<User>().ToList();
        }
    }
}
