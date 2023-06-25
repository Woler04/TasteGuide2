using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasteGuide.Data.Migrations
{
    public partial class rested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                schema: "Identity",
                table: "Restaurant",
                newName: "ImageFile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageFile",
                schema: "Identity",
                table: "Restaurant",
                newName: "ImagePath");
        }
    }
}
