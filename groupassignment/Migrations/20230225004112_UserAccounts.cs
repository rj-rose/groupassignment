using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace groupassignment.Migrations
{
    public partial class UserAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Userid);
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Userid", "Email", "Fname", "Lname", "Password", "Username" },
                values: new object[] { new Guid("b29710ce-f59c-48cc-90e5-cd513e492113"), "rjrose2003@gmail.com", "Rj", "Rose", "Gymnast22", "Sonic3838" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
