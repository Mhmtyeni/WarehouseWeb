using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderBasketLogs_AspNetUsers_AppUserId",
                table: "OrderBasketLogs");

            migrationBuilder.DropIndex(
                name: "IX_OrderBasketLogs_AppUserId",
                table: "OrderBasketLogs");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "OrderBasketLogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "OrderBasketLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderBasketLogs_AppUserId",
                table: "OrderBasketLogs",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBasketLogs_AspNetUsers_AppUserId",
                table: "OrderBasketLogs",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
