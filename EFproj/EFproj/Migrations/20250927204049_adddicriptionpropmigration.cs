using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFproj.Migrations
{
    /// <inheritdoc />
    public partial class adddicriptionpropmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                // now we can see discreption column in the table of employee
                name: "discreption",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discreption",
                table: "Employees");
        }
    }
}
