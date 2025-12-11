using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFPROJECT.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "employees");
        }
    }
}
