using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTorraTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Características",
                table: "Torra",
                newName: "Caracteristicas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Caracteristicas",
                table: "Torra",
                newName: "Características");
        }
    }
}
