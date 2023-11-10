using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationLogin.Migrations
{
    public partial class Remoçãodoemailusuarioepassowrdjáexistiapadrao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email_usuario",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "password_usuario",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email_usuario",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password_usuario",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
