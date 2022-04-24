using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WefqiHobbiesWebApp.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HoursPlayed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFinished = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GraphicsCard = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorageSpace = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentEpsiode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Pc");

            migrationBuilder.DropTable(
                name: "Show");
        }
    }
}
