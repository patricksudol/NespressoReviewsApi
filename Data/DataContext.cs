using Microsoft.EntityFrameworkCore;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Pod> Pods { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<CupSize> CupSizes { get; set; }
    }
}