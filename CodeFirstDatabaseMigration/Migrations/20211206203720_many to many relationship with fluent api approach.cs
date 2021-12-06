using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class manytomanyrelationshipwithfluentapiapproach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1d6b538a-2b83-4532-bcb8-cf72cb8a88bf"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3361bbd4-896c-4707-873c-4366f58dfafe"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("79f9c67e-79f6-42ba-b79b-5eab01e77d87"));

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("ae88f4ac-681a-4258-bd06-ff5475c48336"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("1eca5935-27ac-49de-b418-e621dca91ff7"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("c2ffe8b5-1b66-4fd6-83f6-63e77e77f605"), 28, "Mike Miles" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1eca5935-27ac-49de-b418-e621dca91ff7"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ae88f4ac-681a-4258-bd06-ff5475c48336"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c2ffe8b5-1b66-4fd6-83f6-63e77e77f605"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("1d6b538a-2b83-4532-bcb8-cf72cb8a88bf"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("3361bbd4-896c-4707-873c-4366f58dfafe"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("79f9c67e-79f6-42ba-b79b-5eab01e77d87"), 28, "Mike Miles" });
        }
    }
}
