using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NespressoReviewsApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CupSizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Volume = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PodTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    AccessToken = table.Column<string>(nullable: true),
                    RefreshToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    RefreshToken = table.Column<string>(nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CupSizeId = table.Column<Guid>(nullable: false),
                    PodTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pods_CupSizes_CupSizeId",
                        column: x => x.CupSizeId,
                        principalTable: "CupSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pods_PodTypes_PodTypeId",
                        column: x => x.PodTypeId,
                        principalTable: "PodTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    PodId = table.Column<Guid>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PodReviews_Pods_PodId",
                        column: x => x.PodId,
                        principalTable: "Pods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PodReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CupSizes",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "Notes", "Volume" },
                values: new object[,]
                {
                    { new Guid("09e15f51-a7e5-4b55-8c3e-a4caaff04d2a"), null, null, "Double Espresso", null, 2.7000000476837158 },
                    { new Guid("b2ed35a3-d7f7-4026-a0fd-86494efa7fde"), null, null, "Espresso", null, 1.3500000238418579 },
                    { new Guid("faa9f651-733d-4c72-a851-6bc4d214b7e4"), null, null, "Gran Lungo", null, 5.0 },
                    { new Guid("42600fda-b166-4f78-b5b2-e533d14c5339"), null, null, "Coffee", null, 7.7699999809265137 },
                    { new Guid("e5539f29-beab-4189-9f90-eaf7090ea27f"), null, null, "Coffee", null, 14.0 },
                    { new Guid("b896f0f3-2585-40b8-a6da-2acf52bf7d1d"), null, null, "Craft Brew", null, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "PodTypes",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "Notes", "Order" },
                values: new object[,]
                {
                    { new Guid("6b4a3d93-eb30-4f71-95d9-57e2c176a7a0"), null, null, "Original", null, 1 },
                    { new Guid("149cf1ab-e619-486b-b110-b390db45e431"), null, null, "Vertuo", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[,]
                {
                    { new Guid("6509d9c6-e1ef-47f0-9d25-cb777caf0312"), null, new Guid("09e15f51-a7e5-4b55-8c3e-a4caaff04d2a"), "Test", null, "Giornio", null, new Guid("6b4a3d93-eb30-4f71-95d9-57e2c176a7a0"), 10f },
                    { new Guid("fd8d3bc1-158a-49e0-8f7c-c8328428f8cd"), null, new Guid("09e15f51-a7e5-4b55-8c3e-a4caaff04d2a"), "Test", null, "Vanilla Custard Pie", null, new Guid("6b4a3d93-eb30-4f71-95d9-57e2c176a7a0"), 10f },
                    { new Guid("b805cc7e-acbf-427d-b71a-512f8848be3e"), null, new Guid("09e15f51-a7e5-4b55-8c3e-a4caaff04d2a"), "Test", null, "Cossta Rica", null, new Guid("149cf1ab-e619-486b-b110-b390db45e431"), 10f },
                    { new Guid("e5fa90b4-468d-4221-8195-95e07382e3cf"), null, new Guid("09e15f51-a7e5-4b55-8c3e-a4caaff04d2a"), "Test", null, "Ethiopia", null, new Guid("149cf1ab-e619-486b-b110-b390db45e431"), 10f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PodReviews_PodId",
                table: "PodReviews",
                column: "PodId");

            migrationBuilder.CreateIndex(
                name: "IX_PodReviews_UserId_PodId",
                table: "PodReviews",
                columns: new[] { "UserId", "PodId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pods_CupSizeId",
                table: "Pods",
                column: "CupSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pods_PodTypeId",
                table: "Pods",
                column: "PodTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PodReviews");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.DropTable(
                name: "Pods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CupSizes");

            migrationBuilder.DropTable(
                name: "PodTypes");
        }
    }
}
