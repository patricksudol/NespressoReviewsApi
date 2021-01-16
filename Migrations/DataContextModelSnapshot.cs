﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NespressoReviewsApi.Data;

namespace NespressoReviewsApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NespressoReviewsApi.Models.CupSize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Volume")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("CupSizes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8639f548-cc75-494b-8470-42fa3d10162d"),
                            Name = "Double Espresso",
                            Volume = 2.7000000476837158
                        },
                        new
                        {
                            Id = new Guid("7fdf6dfb-f087-4270-965c-484f08767836"),
                            Name = "Espresso",
                            Volume = 1.3500000238418579
                        },
                        new
                        {
                            Id = new Guid("020d12a7-e9ae-45b3-bd77-7c820ff969ac"),
                            Name = "Gran Lungo",
                            Volume = 5.0
                        },
                        new
                        {
                            Id = new Guid("a343a1f4-b92e-4352-8dab-6508b95f3081"),
                            Name = "Coffee",
                            Volume = 7.7699999809265137
                        },
                        new
                        {
                            Id = new Guid("32c4f87d-ed3b-4ddc-8f8c-e0069fc55e5a"),
                            Name = "Coffee",
                            Volume = 14.0
                        },
                        new
                        {
                            Id = new Guid("cf09a5e7-09e4-4b4c-81da-906dcd06d395"),
                            Name = "Craft Brew",
                            Volume = 18.0
                        });
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.Pod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("CupSizeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("PodTypeId")
                        .HasColumnType("char(36)");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CupSizeId");

                    b.HasIndex("PodTypeId");

                    b.ToTable("Pods");

                    b.HasData(
                        new
                        {
                            Id = new Guid("818fecc5-b2c7-4c9b-a5d6-10bb3ee64dff"),
                            CupSizeId = new Guid("8639f548-cc75-494b-8470-42fa3d10162d"),
                            Description = "Test",
                            Name = "Giornio",
                            PodTypeId = new Guid("cdcdd0c4-6486-48e9-b69d-4d7760d92962"),
                            Price = 10f
                        },
                        new
                        {
                            Id = new Guid("7a52449e-e41a-4014-b765-80de51383a2a"),
                            CupSizeId = new Guid("8639f548-cc75-494b-8470-42fa3d10162d"),
                            Description = "Test",
                            Name = "Vanilla Custard Pie",
                            PodTypeId = new Guid("cdcdd0c4-6486-48e9-b69d-4d7760d92962"),
                            Price = 10f
                        },
                        new
                        {
                            Id = new Guid("46e03fd6-a5a0-47ae-833d-b893dd575a95"),
                            CupSizeId = new Guid("8639f548-cc75-494b-8470-42fa3d10162d"),
                            Description = "Test",
                            Name = "Cossta Rica",
                            PodTypeId = new Guid("eb81beb4-5a11-4a2f-a3f8-b6f05f5ad27e"),
                            Price = 10f
                        },
                        new
                        {
                            Id = new Guid("0fb3c83f-e586-48d6-a20c-d467207d9789"),
                            CupSizeId = new Guid("8639f548-cc75-494b-8470-42fa3d10162d"),
                            Description = "Test",
                            Name = "Ethiopia",
                            PodTypeId = new Guid("eb81beb4-5a11-4a2f-a3f8-b6f05f5ad27e"),
                            Price = 10f
                        });
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.PodReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("PodId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("Score")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PodId");

                    b.HasIndex("UserId", "PodId")
                        .IsUnique();

                    b.ToTable("PodReviews");
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.PodType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PodTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdcdd0c4-6486-48e9-b69d-4d7760d92962"),
                            Name = "Original",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("eb81beb4-5a11-4a2f-a3f8-b6f05f5ad27e"),
                            Name = "Vertuo",
                            Order = 2
                        });
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AccessToken")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.Pod", b =>
                {
                    b.HasOne("NespressoReviewsApi.Models.CupSize", "CupSize")
                        .WithMany("Pod")
                        .HasForeignKey("CupSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NespressoReviewsApi.Models.PodType", "PodType")
                        .WithMany("Pod")
                        .HasForeignKey("PodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.PodReview", b =>
                {
                    b.HasOne("NespressoReviewsApi.Models.Pod", "Pod")
                        .WithMany("PodReview")
                        .HasForeignKey("PodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NespressoReviewsApi.Models.User", "User")
                        .WithMany("PodReview")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
