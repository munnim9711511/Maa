using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class councilupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FifthName",
                table: "CouncilModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FifthPic",
                table: "CouncilModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthName",
                table: "CouncilModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthPic",
                table: "CouncilModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifthName",
                table: "CouncilModels");

            migrationBuilder.DropColumn(
                name: "FifthPic",
                table: "CouncilModels");

            migrationBuilder.DropColumn(
                name: "FourthName",
                table: "CouncilModels");

            migrationBuilder.DropColumn(
                name: "FourthPic",
                table: "CouncilModels");
        }
    }
}
