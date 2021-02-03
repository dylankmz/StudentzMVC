using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentzMVC.Data.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    birthDate = table.Column<DateTime>(nullable: false),
                    studentGender = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    phoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    address = table.Column<string>(nullable: false),
                    houseNumber = table.Column<int>(nullable: false),
                    zip = table.Column<int>(nullable: false),
                    location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
