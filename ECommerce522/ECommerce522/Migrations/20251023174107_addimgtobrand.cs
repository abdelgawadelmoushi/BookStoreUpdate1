using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce522.Migrations
{
    /// <inheritdoc />
    public partial class addimgtobrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue:"");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "brands");
        }
    }
}
