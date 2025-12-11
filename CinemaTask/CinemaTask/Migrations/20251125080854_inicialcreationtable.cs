using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaTask.Migrations
{
    /// <inheritdoc />
    public partial class inicialcreationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ac",
                table: "Ac");

            migrationBuilder.RenameTable(
                name: "Ac",
                newName: "Actors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Ac");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ac",
                table: "Ac",
                column: "Id");
        }
    }
}
