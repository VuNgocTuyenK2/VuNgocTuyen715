using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuNgocTuyen715.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Faculty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<string>(type: "TEXT", nullable: false),
                    FacultyName = table.Column<string>(type: "TEXT", nullable: false),
                    PhongBan = table.Column<string>(type: "TEXT", nullable: false),
                    StudentId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyId);
                    table.ForeignKey(
                        name: "FK_Faculty_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_StudentId",
                table: "Faculty",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
