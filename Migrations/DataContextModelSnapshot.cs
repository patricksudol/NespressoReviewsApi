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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
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
                            Id = new Guid("9971350a-f5ab-4753-aeff-647a45a864c6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Double Espresso",
                            Volume = 2.7000000476837158
                        },
                        new
                        {
                            Id = new Guid("501b8bb6-5bff-4049-a0cb-c4582bc23c5f"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Espresso",
                            Volume = 1.3500000238418579
                        },
                        new
                        {
                            Id = new Guid("afbd11e4-4a60-497e-8f54-1f3438cd9964"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gran Lungo",
                            Volume = 5.0
                        },
                        new
                        {
                            Id = new Guid("ed6e8285-9c7d-4d3f-87f7-c1829d0f20ec"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Coffee",
                            Volume = 7.7699999809265137
                        },
                        new
                        {
                            Id = new Guid("33735f84-db11-42c0-b6ef-ef6f749512ce"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Coffee",
                            Volume = 14.0
                        },
                        new
                        {
                            Id = new Guid("07339a5c-bb76-4125-ae60-ff53b2b69cc8"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Craft Brew",
                            Volume = 18.0
                        });
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("CupSizeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("ModifiedDate")
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
                            Id = new Guid("7e6e647f-a898-4e38-a495-d7c844082e8a"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CupSizeId = new Guid("9971350a-f5ab-4753-aeff-647a45a864c6"),
                            Description = "Test",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Giornio",
                            PodTypeId = new Guid("9459c1ec-a41b-4d75-80a8-1488ca410e39"),
                            Price = 10f
                        });
                });

            modelBuilder.Entity("NespressoReviewsApi.Models.PodReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("ModifiedDate")
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
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
                            Id = new Guid("9459c1ec-a41b-4d75-80a8-1488ca410e39"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Original",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("a174db86-0396-4412-ae2d-519d276b23f8"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ModifiedDate")
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

                    b.Property<DateTime>("CreatedDate")
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

                    b.Property<DateTime>("ModifiedDate")
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
