using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_3.Data.Migrations
{
    public partial class personmodel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Person");
        }
    }
}
