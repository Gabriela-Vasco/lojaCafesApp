using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoEntreClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TorraCafeId",
                table: "Cafe",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cafe_TorraCafeId",
                table: "Cafe",
                column: "TorraCafeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafe_TorraCafe_TorraCafeId",
                table: "Cafe",
                column: "TorraCafeId",
                principalTable: "TorraCafe",
                principalColumn: "TorraCafeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafe_TorraCafe_TorraCafeId",
                table: "Cafe");

            migrationBuilder.DropIndex(
                name: "IX_Cafe_TorraCafeId",
                table: "Cafe");

            migrationBuilder.DropColumn(
                name: "TorraCafeId",
                table: "Cafe");
        }
    }
}
