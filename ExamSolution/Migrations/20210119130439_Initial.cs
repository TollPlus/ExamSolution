using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamSolution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassDetails",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Standard = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDetails", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Grade = table.Column<string>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    ClassDetailsModelClassId = table.Column<int>(nullable: true),
                    Section = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_ClassDetails_ClassDetailsModelClassId",
                        column: x => x.ClassDetailsModelClassId,
                        principalTable: "ClassDetails",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true),
                    ClassId = table.Column<int>(nullable: false),
                    ClassDetailsModelClassId = table.Column<int>(nullable: true),
                    Subject = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_ClassDetails_ClassDetailsModelClassId",
                        column: x => x.ClassDetailsModelClassId,
                        principalTable: "ClassDetails",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassDetailsModelClassId",
                table: "Students",
                column: "ClassDetailsModelClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassDetailsModelClassId",
                table: "Teachers",
                column: "ClassDetailsModelClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "ClassDetails");
        }
    }
}
