using System;
using Microsoft.EntityFrameworkCore.Migrations;



//this file contain and describe the newly created migration.

namespace CodeFirstDatabaseMigration.Migrations
{
    public partial class InitialMigration : Migration
    {
        //The Up method consists of commands that will be executed when we apply this migration
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: true),
                    IsRegularStudent = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });
        }

        //As an opposite action,
        //the Down method will execute commands when we remove this migration (in this case it will just drop this created table).
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
