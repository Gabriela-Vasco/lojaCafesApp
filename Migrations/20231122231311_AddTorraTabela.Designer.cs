﻿// <auto-generated />
using System;
using lojaCafesApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace lojaCafesApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231122231311_AddTorraTabela")]
    partial class AddTorraTabela
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("lojaCafesApp.Models.Cafe", b =>
                {
                    b.Property<int>("CafeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("CafeId");

                    b.ToTable("Cafe");
                });

            modelBuilder.Entity("lojaCafesApp.Models.TorraCafe", b =>
                {
                    b.Property<int>("TorraCafeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TorraCafeId");

                    b.ToTable("TorraCafe");
                });
#pragma warning restore 612, 618
        }
    }
}
