using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class important_location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportantLocationModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    TitleEng = table.Column<string>(nullable: true),
                    ImgUrl1 = table.Column<string>(nullable: true),
                    ImgUrl2 = table.Column<string>(nullable: true),
                    ImgUrl3 = table.Column<string>(nullable: true),
                    ImgUrl4 = table.Column<string>(nullable: true),
                    ImgUrl5 = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    TextEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportantLocationModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportantLocationModels");
        }
    }
}
