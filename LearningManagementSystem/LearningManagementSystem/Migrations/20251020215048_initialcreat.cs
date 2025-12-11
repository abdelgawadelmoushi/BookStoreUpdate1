using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class initialcreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartementId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructors_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courses_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "instructorCourses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructorCourses", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_instructorCourses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_instructorCourses_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subImgCourses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subImgCourses", x => new { x.CourseId, x.Img });
                    table.ForeignKey(
                        name: "FK_subImgCourses_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_InstructorId",
                table: "courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_instructorCourses_InstructorId",
                table: "instructorCourses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instructorCourses");

            migrationBuilder.DropTable(
                name: "subImgCourses");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
