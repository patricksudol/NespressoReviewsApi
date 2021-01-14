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
                    Description = table.Column<string>(nullable: false),
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
                    { new Guid("d8c957fb-ff27-4a83-bcdb-9bbd8947cbed"), null, null, "Double Espresso", null, 2.7000000476837158 },
                    { new Guid("6c48cfe3-146a-4645-a1a0-d6ecf8bc5152"), null, null, "Espresso", null, 1.3500000238418579 },
                    { new Guid("300c712f-3ccc-45e5-9ee1-d0e73e398d6d"), null, null, "Gran Lungo", null, 5.0 },
                    { new Guid("e8799de6-4697-490a-a8a6-a71633c07dc3"), null, null, "Coffee", null, 7.7699999809265137 },
                    { new Guid("88a3081d-950b-4fe3-80cd-267b128ccbcc"), null, null, "Coffee", null, 14.0 },
                    { new Guid("9c4f4e10-55ee-4641-ae01-abf67f066036"), null, null, "Craft Brew", null, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "PodTypes",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "Notes", "Order" },
                values: new object[,]
                {
                    { new Guid("26ed8ec0-f41b-4cf5-bb84-72455b914ff9"), null, null, "Original", null, 1 },
                    { new Guid("69b310d8-9dab-4849-86a6-f47311aa241c"), null, null, "Vertuo", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[] { new Guid("6bed5c83-1208-4979-b7f4-a479ee1e24f2"), null, new Guid("d8c957fb-ff27-4a83-bcdb-9bbd8947cbed"), "Test", null, "Giornio", null, new Guid("26ed8ec0-f41b-4cf5-bb84-72455b914ff9"), 10f });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[] { new Guid("7e6faee9-c25b-4077-8660-da684e0c48cc"), null, new Guid("d8c957fb-ff27-4a83-bcdb-9bbd8947cbed"), "Test", null, "Vanilla Custard Pie", null, new Guid("26ed8ec0-f41b-4cf5-bb84-72455b914ff9"), 10f });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[] { new Guid("6f91bf42-14c2-41b8-8342-f77e3973a2c5"), null, new Guid("d8c957fb-ff27-4a83-bcdb-9bbd8947cbed"), "Test", null, "Cossta Rica", null, new Guid("26ed8ec0-f41b-4cf5-bb84-72455b914ff9"), 10f });

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
