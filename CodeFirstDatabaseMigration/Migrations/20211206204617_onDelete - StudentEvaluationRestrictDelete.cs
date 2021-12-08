using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class onDeleteStudentEvaluationRestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

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
                values: new object[] { new Guid("9684dffe-f6d5-42c3-ae6c-3319edbd8f60"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("166102bf-84d9-4feb-80df-8e7bc2fb168c"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("9be42b9f-5d46-4c32-93fe-c95c2d3ab323"), 28, "Mike Miles" });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("166102bf-84d9-4feb-80df-8e7bc2fb168c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9684dffe-f6d5-42c3-ae6c-3319edbd8f60"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9be42b9f-5d46-4c32-93fe-c95c2d3ab323"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Student_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
