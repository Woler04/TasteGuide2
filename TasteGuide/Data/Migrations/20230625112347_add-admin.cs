using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasteGuide.Data.Migrations
{
    public partial class addadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                schema: "Identity",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                schema: "Identity",
                table: "AspNetUsers");
        }
    }
}
