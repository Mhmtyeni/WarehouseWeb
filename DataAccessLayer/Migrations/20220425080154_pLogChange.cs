using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class pLogChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ProductLogs",
                newName: "LastQuantity");

            migrationBuilder.AddColumn<int>(
                name: "FirstQuantity",
                table: "ProductLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstQuantity",
                table: "ProductLogs");

            migrationBuilder.RenameColumn(
                name: "LastQuantity",
                table: "ProductLogs",
                newName: "Quantity");
        }
    }
}
