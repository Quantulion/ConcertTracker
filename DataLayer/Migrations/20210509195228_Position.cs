using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Position_Lat",
                table: "Concerts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Position_Lng",
                table: "Concerts",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position_Lat",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "Position_Lng",
                table: "Concerts");
        }
    }
}
