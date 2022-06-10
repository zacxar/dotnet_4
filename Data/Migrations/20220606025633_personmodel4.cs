using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_3.Data.Migrations
{
    public partial class personmodel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
