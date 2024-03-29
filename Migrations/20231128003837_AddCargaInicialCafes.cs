﻿using lojaCafesApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaCafesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCargaInicialCafes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           CarregarListInicial();

            foreach (var cafe in _cafes)
            {
                migrationBuilder.InsertData(
                    table: "Cafe",
                    columns: new[] { "CafeId", "Nome", "Descricao", "ImageUri", "Preco", "EntregaExpressa", "DataCadastro" },
                    values: new object[] { cafe.CafeId, cafe.Nome, cafe.Descricao, cafe.ImageUri, cafe.Preco, cafe.EntregaExpressa, cafe.DataCadastro });
            }  
        }

        private List<Cafe> _cafes;

        private void CarregarListInicial()
        {
            _cafes = new List<Cafe>()
            {
                new Cafe
                {
                    CafeId = 14,
                    Nome = "Café Arábica",
                    Descricao = "Considerado uma das variedades de café de maior qualidade, os grãos de café arábica têm um sabor mais suave e menos cafeína em comparação com outras variedades. Eles são cultivados em altitudes mais elevadas, geralmente em regiões de clima mais fresco.",
                    ImageUri = "/images/coffeebag1.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now
                },
                new Cafe
                {
                    CafeId = 15,
                    Nome = "Café Liberica",
                    Descricao = "Os grãos de café robusta têm um sabor mais forte e mais amargo em comparação com o arábica. Eles contêm mais cafeína e são frequentemente usados em cafés expressos e misturas de café mais encorpadas.",
                    ImageUri = "/images/coffeebag2.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now
                },
                new Cafe
                {
                    CafeId = 16,
                    Nome = "Café Robusta",
                    Descricao = "Menos comum do que o arábica e o robusta, o café liberica tem um sabor único, muitas vezes descrito como frutado e floral. É cultivado principalmente na África e no sudeste asiático.",
                    ImageUri = "/images/coffeebag3.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now,
                },
                new Cafe
                {
                    CafeId = 17,
                    Nome = "Café Excelsa",
                    Descricao = "Conhecido por sua complexidade de sabor. Ele é muitas vezes utilizado em blends para adicionar uma dimensão única ao sabor do café. A diversidade de grãos de café contribui para a rica experiência sensorial que os amantes de café apreciam ao explorar diferentes origens e variedades.",
                    ImageUri = "/images/coffeebag4.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now
                },
                new Cafe
                {
                    CafeId = 18,
                    Nome = "Café Aurum",
                    Descricao = "Este café oferece uma experiência sensorial excepcional, com notas iniciais de caramelo suave e nuances de frutas tropicais maduras. À medida que o café é apreciado, revela camadas de cacau amargo e um toque sutil de especiarias exóticas. O Aromática Aurum é conhecido por sua acidez equilibrada e um final prolongado, deixando uma sensação aveludada na boca.",
                    ImageUri = "/images/coffeebag5.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now
                },
                new Cafe
                {
                    CafeId = 19,
                    Nome = "Café Ébano",
                    Descricao = "Este café oferece uma jornada sensorial única com notas profundas de especiarias exóticas, complementadas por uma suavidade sedosa. O Ébano Eterno é caracterizado por sua complexidade intrigante, evocando sabores que lembram uma combinação de cardamomo, cedro e um toque sutil de frutas vermelhas.",
                    ImageUri = "/images/coffeebag6.png",
                    Preco = 45.00,
                    EntregaExpressa = true,
                    DataCadastro = DateTime.Now
                }
            };
        }
    }
}
