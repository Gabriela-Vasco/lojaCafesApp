using Microsoft.EntityFrameworkCore.Migrations;
using lojaCafesApp.Models;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTorraCafeCargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TorraCafe",
                columns: new[] { "Nome" },
                values: new object[,]
                {
                    { "Torra Clara" },
                    { "Torra Média Clara" },
                    { "Torra Média" },
                    { "Torra Média Escura" },
                    { "Torra Escura" },
                    { "Torra Italiana" },
                    { "Torra Francesa" },
                }
            );
        }
    }
}
