using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SensiveProject.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Artikels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artikels_AppUserId",
                table: "Artikels",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikels_AspNetUsers_AppUserId",
                table: "Artikels",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikels_AspNetUsers_AppUserId",
                table: "Artikels");

            migrationBuilder.DropIndex(
                name: "IX_Artikels_AppUserId",
                table: "Artikels");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Artikels");
        }
    }
}
