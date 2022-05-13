using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CreateAt", "FirstName", "LastName" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2022, 5, 6, 16, 27, 53, 892, DateTimeKind.Unspecified).AddTicks(2730), new TimeSpan(0, 1, 0, 0, 0)), " Kolawole", " Adebayo" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "CreateAt", "FirstName", "LastName" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2022, 5, 6, 16, 27, 53, 892, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 1, 0, 0, 0)), " Olawole", " George" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
