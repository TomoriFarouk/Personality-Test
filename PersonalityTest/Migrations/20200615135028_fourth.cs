using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalityTest.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionGs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionFs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionDs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionCs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionBs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsersId",
                table: "sectionAs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionGs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionFs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionEs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionDs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionCs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionBs");

            migrationBuilder.DropColumn(
                name: "AspNetUsersId",
                table: "sectionAs");
        }
    }
}
