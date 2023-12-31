using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StdMgtSystem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Branch = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Section = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Gender = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
