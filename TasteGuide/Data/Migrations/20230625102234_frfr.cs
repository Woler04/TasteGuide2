using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasteGuide.Data.Migrations
{
    public partial class frfr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Restaurant_RestaurantId",
                schema: "Identity",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurant",
                schema: "Identity",
                table: "Restaurant");

            migrationBuilder.RenameTable(
                name: "Restaurant",
                schema: "Identity",
                newName: "Restaurants",
                newSchema: "Identity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurants",
                schema: "Identity",
                table: "Restaurants",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantId",
                schema: "Identity",
                table: "Reviews",
                column: "RestaurantId",
                principalSchema: "Identity",
                principalTable: "Restaurants",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Restaurants_RestaurantId",
                schema: "Identity",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurants",
                schema: "Identity",
                table: "Restaurants");

            migrationBuilder.RenameTable(
                name: "Restaurants",
                schema: "Identity",
                newName: "Restaurant",
                newSchema: "Identity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurant",
                schema: "Identity",
                table: "Restaurant",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Restaurant_RestaurantId",
                schema: "Identity",
                table: "Reviews",
                column: "RestaurantId",
                principalSchema: "Identity",
                principalTable: "Restaurant",
                principalColumn: "Id");
        }
    }
}
