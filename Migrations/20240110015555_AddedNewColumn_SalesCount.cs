using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationStudy.Migrations
{
    public partial class AddedNewColumn_SalesCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalesCount",
                table: "SalesProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalesCount",
                table: "SalesProducts");
        }
    }
}
