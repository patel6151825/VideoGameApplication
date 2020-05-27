using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameApplication.Migrations
{
    public partial class FirstVersionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    PublicationYear = table.Column<int>(nullable: false),
                    MinimumPlayers = table.Column<int>(nullable: false),
                    MaximumPlayers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGame");
        }
    }
}
