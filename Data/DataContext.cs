using System;
using Microsoft.EntityFrameworkCore;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<PodType> PodTypes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Pod> Pods { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<CupSize> CupSizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PodReview>();
            modelBuilder.Entity<PodType>().HasData(
                new PodType { Id = Guid.NewGuid(), Name = "Original", Order = 1 },
                new PodType { Id = Guid.NewGuid(), Name = "Vertuo", Order = 2 }
            );

            modelBuilder.Entity<CupSize>().HasData(
                new CupSize { Id = Guid.NewGuid(), Name = "Double Espresso", Volume = (float)2.7f },
                new CupSize { Id = Guid.NewGuid(), Name = "Espresso", Volume = (float)1.35f },
                new CupSize { Id = Guid.NewGuid(), Name = "Gran Lungo", Volume = 5 },
                new CupSize { Id = Guid.NewGuid(), Name = "Coffee", Volume = (float)7.77f },
                new CupSize { Id = Guid.NewGuid(), Name = "Coffee", Volume = (float)14.00f },
                new CupSize { Id = Guid.NewGuid(), Name = "Craft Brew", Volume = 18 }
            );
        }
    }
}