using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemTask.Data.Migrations
{
    public partial class asd2s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "TehnicalEmployees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "TehnicalEmployees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "TehnicalEmployees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "TehnicalEmployees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "TehnicalEmployees");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "TehnicalEmployees");
        }
    }
}
