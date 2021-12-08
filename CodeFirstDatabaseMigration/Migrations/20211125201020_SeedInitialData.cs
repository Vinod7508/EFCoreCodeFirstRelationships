using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("54956463-715d-45d7-b97a-e9f26fff78f0"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("48a2e77a-1a48-42f8-b2f0-e9820882c495"), 25, "Jane Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("48a2e77a-1a48-42f8-b2f0-e9820882c495"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("54956463-715d-45d7-b97a-e9f26fff78f0"));
        }
    }
}
