using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaTask.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Categories_CategoryId",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Movies_MovieId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_CategoryId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_MovieId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Movies",
                newName: "MainImg");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Cinemas",
                newName: "CinemaId");

            migrationBuilder.RenameColumn(
                name: "MainImg",
                table: "Cinemas",
                newName: "Img");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Movies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "MainImg",
                table: "Movies",
                newName: "Img");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Cinemas",
                newName: "MainImg");

            migrationBuilder.RenameColumn(
                name: "CinemaId",
                table: "Cinemas",
                newName: "Quantity");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Cinemas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cinemas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Cinemas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_CategoryId",
                table: "Cinemas",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_MovieId",
                table: "Cinemas",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Categories_CategoryId",
                table: "Cinemas",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Movies_MovieId",
                table: "Cinemas",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
