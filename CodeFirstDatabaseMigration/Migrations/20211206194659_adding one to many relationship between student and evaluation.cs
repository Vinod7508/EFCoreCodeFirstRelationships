using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class addingonetomanyrelationshipbetweenstudentandevaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1b78e0a5-ea14-4bd8-86a9-c6aa5be1f87f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("eb4edac4-f78d-4825-918a-8d7e404f1155"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f350578b-6e59-4bc3-8441-e312c979b0e3"));

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<Guid>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    AdditionalExplanation = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluation",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("f350578b-6e59-4bc3-8441-e312c979b0e3"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("1b78e0a5-ea14-4bd8-86a9-c6aa5be1f87f"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("eb4edac4-f78d-4825-918a-8d7e404f1155"), 28, "Mike Miles" });
        }
    }
}
