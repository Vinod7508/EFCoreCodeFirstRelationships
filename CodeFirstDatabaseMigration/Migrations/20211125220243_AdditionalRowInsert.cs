using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class AdditionalRowInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("48a2e77a-1a48-42f8-b2f0-e9820882c495"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("54956463-715d-45d7-b97a-e9f26fff78f0"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("94e33e59-1fb9-4039-b78b-a2bbf88c3428"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("d69d2025-907c-4062-8ccb-aae392cbb006"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("71b654e3-2319-4b1b-b6cf-bb8c5f31b3ae"), 28, "Mike Miles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("71b654e3-2319-4b1b-b6cf-bb8c5f31b3ae"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("94e33e59-1fb9-4039-b78b-a2bbf88c3428"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("d69d2025-907c-4062-8ccb-aae392cbb006"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("54956463-715d-45d7-b97a-e9f26fff78f0"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("48a2e77a-1a48-42f8-b2f0-e9820882c495"), 25, "Jane Doe" });
        }
    }
}
