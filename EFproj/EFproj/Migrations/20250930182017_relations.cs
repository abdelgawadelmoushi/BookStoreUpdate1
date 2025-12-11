using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFproj.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.Category_Id, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Items_ProductsId",
                        column: x => x.ProductsId,
                        principalSchema: "Production",
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");
        }
    }
}
