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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
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
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PodId = table.Column<Guid>(nullable: false)
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
                    { new Guid("05c281b6-d963-4d4b-9ffb-c4ec925884c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Double Espresso", null, 2.7000000476837158 },
                    { new Guid("18f7cb87-5def-474b-9b23-daa59c031c88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Espresso", null, 1.3500000238418579 },
                    { new Guid("4bb0af9c-9b6d-4cb0-bc01-ce6c679e9c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gran Lungo", null, 5.0 },
                    { new Guid("dd049851-1b88-4a55-86f9-474636b931aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee", null, 7.7699999809265137 },
                    { new Guid("de521af0-b7be-469b-b788-7c3e1004d64d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee", null, 14.0 },
                    { new Guid("f9f03491-aabf-470e-95b3-0e11b3892e48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Craft Brew", null, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "PodTypes",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "Notes", "Order" },
                values: new object[,]
                {
                    { new Guid("66213b56-1888-4081-bf44-e9169eb245b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Original", null, 1 },
                    { new Guid("29811665-2763-4a32-9fa0-a656aede5399"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vertuo", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "EmailAddress", "FirstName", "LastName", "ModifiedDate", "Notes" },
                values: new object[] { new Guid("361f6729-7c9c-4a99-84f5-11e81c29bb1f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "patrick.sudol@icloud.com", "Patrick", "Sudol", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Pods",
                columns: new[] { "Id", "CreatedDate", "CupSizeId", "Description", "ModifiedDate", "Name", "Notes", "PodTypeId", "Price" },
                values: new object[] { new Guid("81ad6749-4963-4864-acc0-8d10e3282d31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05c281b6-d963-4d4b-9ffb-c4ec925884c4"), "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giornio", null, new Guid("66213b56-1888-4081-bf44-e9169eb245b5"), 10f });

            migrationBuilder.CreateIndex(
                name: "IX_PodReviews_PodId",
                table: "PodReviews",
                column: "PodId");

            migrationBuilder.CreateIndex(
                name: "IX_PodReviews_UserId",
                table: "PodReviews",
                column: "UserId");

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
