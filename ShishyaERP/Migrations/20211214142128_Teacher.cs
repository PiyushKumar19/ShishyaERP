using Microsoft.EntityFrameworkCore.Migrations;

namespace ShishyaERP.Migrations
{
    public partial class Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TTeachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherAge = table.Column<int>(type: "int", nullable: false),
                    teacherGender = table.Column<int>(type: "int", nullable: false),
                    bgroup = table.Column<int>(type: "int", nullable: false),
                    teacherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    graduatedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teachCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTeachers", x => x.teacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TTeachers");
        }
    }
}
