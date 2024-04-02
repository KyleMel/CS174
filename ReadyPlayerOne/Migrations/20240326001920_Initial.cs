using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadyPlayerOne.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Stealth = table.Column<int>(type: "int", nullable: false),
                    Luck = table.Column<int>(type: "int", nullable: false),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Alignment", "Class", "Health", "Intelligence", "Luck", "PlayerName", "Stamina", "Stealth", "Strength" },
                values: new object[] { 1, "True Neutral", "Mage", 3, 9, 8, "Esther Ulrick", 3, 6, 2 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Alignment", "Class", "Health", "Intelligence", "Luck", "PlayerName", "Stamina", "Stealth", "Strength" },
                values: new object[] { 2, "Lawful Good", "Warrior", 8, 2, 2, "Rhiordan Tannick", 8, 2, 3 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Alignment", "Class", "Health", "Intelligence", "Luck", "PlayerName", "Stamina", "Stealth", "Strength" },
                values: new object[] { 3, "Chaotic Neutral", "Rogue", 6, 7, 7, "Bevil Starling", 5, 9, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
