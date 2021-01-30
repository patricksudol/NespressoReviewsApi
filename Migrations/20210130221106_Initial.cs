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
                    { new Guid("e3e4cac7-ec79-4adc-9063-c44b7e207f72"), null, null, "Double Espresso", null, 2.7000000476837158 },
                    { new Guid("925017e3-0e05-4ea0-bf07-39d89dae2c4a"), null, null, "Espresso", null, 1.3500000238418579 },
                    { new Guid("80078126-e891-4445-a2e0-7a59868bb500"), null, null, "Gran Lungo", null, 5.0 },
                    { new Guid("9f7e5026-eb5f-4de8-abf2-2cc94f5284ea"), null, null, "Coffee", null, 7.7699999809265137 },
                    { new Guid("81083f4b-f9aa-47c9-b30a-a239b2b42be4"), null, null, "Coffee", null, 14.0 },
                    { new Guid("abf2506b-6f55-437c-8dae-01b3f6a69aa5"), null, null, "Craft Brew", null, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "PodTypes",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "Notes", "Order" },
                values: new object[,]
                {
                    { new Guid("e48e2b22-6635-4cfc-864b-23832bbecec3"), null, null, "Original", null, 1 },
                    { new Guid("a217f851-e530-48c9-bb1e-9f56bac9d484"), null, null, "Vertuo", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[,]
                {
                    { new Guid("5288433a-725f-443e-bd86-c46bb0cd9ac7"), null, new Guid("e3e4cac7-ec79-4adc-9063-c44b7e207f72"), "Test", null, "Giornio", null, new Guid("e48e2b22-6635-4cfc-864b-23832bbecec3"), 10f },
                    { new Guid("6eda16b7-b118-4666-81c4-59cd7bc3c340"), null, new Guid("e3e4cac7-ec79-4adc-9063-c44b7e207f72"), "Test", null, "Vanilla Custard Pie", null, new Guid("e48e2b22-6635-4cfc-864b-23832bbecec3"), 10f },
                    { new Guid("f0be15d6-da35-4c32-87b7-bf5c2443e332"), null, new Guid("e3e4cac7-ec79-4adc-9063-c44b7e207f72"), "Test", null, "Cossta Rica", null, new Guid("a217f851-e530-48c9-bb1e-9f56bac9d484"), 10f },
                    { new Guid("c052eb34-261d-43b7-a736-044f8fcb5606"), null, new Guid("e3e4cac7-ec79-4adc-9063-c44b7e207f72"), "Test", null, "Ethiopia", null, new Guid("a217f851-e530-48c9-bb1e-9f56bac9d484"), 10f }
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
