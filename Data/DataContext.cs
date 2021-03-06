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
        public DbSet<PodReview> PodReviews { get; set; }
        public DbSet<Pod> Pods { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<CupSize> CupSizes { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var podTypeIdOne = Guid.NewGuid();
            var podTypeIdTwo = Guid.NewGuid();
            var cupSizeId = Guid.NewGuid();

            modelBuilder.Entity<PodReview>().HasIndex(p => new {p.UserId , p.PodId}).IsUnique();

            modelBuilder.Entity<PodType>().HasData(
                new PodType { Id = podTypeIdOne, Name = "Original", Order = 1 },
                new PodType { Id = podTypeIdTwo, Name = "Vertuo", Order = 2 }
            );

            modelBuilder.Entity<CupSize>().HasData(
                new CupSize { Id = cupSizeId, Name = "Double Espresso", Volume = (float)2.7f },
                new CupSize { Id = Guid.NewGuid(), Name = "Espresso", Volume = (float)1.35f },
                new CupSize { Id = Guid.NewGuid(), Name = "Gran Lungo", Volume = 5 },
                new CupSize { Id = Guid.NewGuid(), Name = "Coffee", Volume = (float)7.77f },
                new CupSize { Id = Guid.NewGuid(), Name = "Coffee", Volume = (float)14.00f },
                new CupSize { Id = Guid.NewGuid(), Name = "Craft Brew", Volume = 18 }
            );

            modelBuilder.Entity<Pod>().HasData(
                new Pod { 
                    Id = Guid.NewGuid(),
                    CupSizeId = cupSizeId,
                    PodTypeId = podTypeIdOne,
                    Name = "Giornio",
                    Price = (float)10.00f,
                    Description = "Test",
                },
                new Pod { 
                    Id = Guid.NewGuid(),
                    CupSizeId = cupSizeId,
                    PodTypeId = podTypeIdOne,
                    Name = "Vanilla Custard Pie",
                    Price = (float)10.00f,
                    Description = "Test",
                },
                new Pod { 
                    Id = Guid.NewGuid(),
                    CupSizeId = cupSizeId,
                    PodTypeId = podTypeIdTwo,
                    Name = "Cossta Rica",
                    Price = (float)10.00f,
                    Description = "Test",
                },
                new Pod { 
                    Id = Guid.NewGuid(),
                    CupSizeId = cupSizeId,
                    PodTypeId = podTypeIdTwo,
                    Name = "Ethiopia",
                    Price = (float)10.00f,
                    Description = "Test",
                }
            );
        }
    }
}
