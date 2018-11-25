using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class cafey_data_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextEng",
                table: "GuestHousesModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleEng",
                table: "GuestHousesModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextEng",
                table: "GuestHousesModels");

            migrationBuilder.DropColumn(
                name: "TitleEng",
                table: "GuestHousesModels");
        }
    }
}
