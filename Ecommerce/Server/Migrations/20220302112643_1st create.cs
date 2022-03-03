using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Server.Migrations
{
    public partial class _1stcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "MIT’s new mini cheetah robot is springy and light on its feet, with a range of motion that rivals a champion gymnast. The four-legged powerpack can bend and swing its legs wide, enabling it to walk either right-side up or upside down. The robot can also trot over uneven terrain about twice as fast as an average person’s walking speed.", "https://robots.ieee.org/robots/minicheetah/minicheetah-thumb@2x.jpg", 100m, "Cheetah" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Spot is an agile mobile robot that navigates terrain with unprecedented mobility, allowing you to automate routine inspection tasks and data capture safely, accurately, and frequently. The results? Safer, more efficient and more predictable operations.", "https://static.wikia.nocookie.net/robotics/images/6/64/38AB8AB0-0E22-4200-A4A6-382335BEEC5E.jpeg", 111m, "Spot" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Atlas has one of the world’s most compact mobile hydraulic systems. A custom battery, valves, and a compact hydraulic power unit enable Atlas to deliver high power to any of its 28 hydraulic joints for impressive feats of mobility.", "https://i.pinimg.com/originals/d3/33/3f/d3333fc913a33c7d3bde8ee006dc1323.png", 299m, "Atlas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
