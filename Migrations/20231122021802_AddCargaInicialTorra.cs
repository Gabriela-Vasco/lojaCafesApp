using lojaCafesApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi.Helpers;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCargaInicialTorra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();
            context.Torra.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private IList<Torra> ObterCargaInicial(){
            return new List<Torra>()
            {
                new Torra() {
                    Nome = "Torra clara",
                    Caracteristicas = "Grãos de cor mais clara, muitas vezes apresentando uma tonalidade de canela. Este perfil preserva as características originais do grão, com acidez mais pronunciada e sabores mais frutados e florais."
                },
                new Torra() {
                    Nome = "Torra Média Clara",
                    Caracteristicas = "Um pouco mais escura do que a torra clara, com grãos de uma cor mais marrom. A acidez ainda é perceptível, mas os sabores tornam-se mais equilibrados, com notas de nozes e chocolate."
                }
            };
        }
    }
}
