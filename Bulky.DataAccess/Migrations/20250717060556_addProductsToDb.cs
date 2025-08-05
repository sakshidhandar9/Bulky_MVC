using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Andrew Hunt", "A practical guide to programming.", "978-0135957059", 550.0, 500.0, 450.0, 480.0, "The Pragmatic Programmer" },
                    { 2, "Robert C. Martin", "A Handbook of Agile Software Craftsmanship.", "978-0132350884", 600.0, 580.0, 530.0, 550.0, "Clean Code" },
                    { 3, "Erich Gamma", "Elements of Reusable Object-Oriented Software.", "978-0201633610", 700.0, 680.0, 630.0, 660.0, "Design Patterns" },
                    { 4, "Thomas H. Cormen", "Widely used textbook for algorithms.", "978-0262033848", 900.0, 880.0, 820.0, 850.0, "Introduction to Algorithms" },
                    { 5, "Martin Fowler", "Improving the Design of Existing Code.", "978-0201485677", 750.0, 720.0, 680.0, 700.0, "Refactoring" },
                    { 6, "Eric Evans", "Tackling Complexity in the Heart of Software.", "978-0321125217", 850.0, 820.0, 780.0, 800.0, "Domain-Driven Design" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
