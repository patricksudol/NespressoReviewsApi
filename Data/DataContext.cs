using Microsoft.EntityFrameworkCore;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
    }
}