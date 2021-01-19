using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSolution.Migrations
{
    public partial class addedimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeacherImage",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentImage",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherImage",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentImage",
                table: "Students");
        }
    }
}
