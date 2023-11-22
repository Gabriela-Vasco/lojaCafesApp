using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTorraTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafe_Torra_TorraId1",
                table: "Cafe");

            migrationBuilder.DropIndex(
                name: "IX_Cafe_TorraId1",
                table: "Cafe");

            migrationBuilder.DropColumn(
                name: "TorraId1",
                table: "Cafe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TorraId1",
                table: "Cafe",
                type: "INTEGER",
                nullable: true);

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
    }
}
