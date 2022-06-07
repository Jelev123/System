using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemTask.Data.Migrations
{
    public partial class assdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "TehnicalEmployees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "TehnicalEmployees");
        }
    }
}
