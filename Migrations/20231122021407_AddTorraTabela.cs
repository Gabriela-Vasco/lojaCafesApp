using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTorraTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TorraId1",
                table: "Cafe",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Torra",
                columns: table => new
                {
                    TorraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Características = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torra", x => x.TorraId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cafe_TorraId1",
                table: "Cafe",
                column: "TorraId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafe_Torra_TorraId1",
                table: "Cafe",
                column: "TorraId1",
                principalTable: "Torra",
                principalColumn: "TorraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafe_Torra_TorraId1",
                table: "Cafe");

            migrationBuilder.DropTable(
                name: "Torra");

            migrationBuilder.DropIndex(
                name: "IX_Cafe_TorraId1",
                table: "Cafe");

            migrationBuilder.DropColumn(
                name: "TorraId1",
                table: "Cafe");
        }
    }
}
