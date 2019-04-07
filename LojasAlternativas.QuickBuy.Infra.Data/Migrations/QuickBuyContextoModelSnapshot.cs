﻿// <auto-generated />
using System;
using LojasAlternativas.QuickBuy.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojasAlternativas.QuickBuy.Infra.Data.Migrations
{
    [DbContext(typeof(QuickBuyContexto))]
    partial class QuickBuyContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<int?>("VendaId");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ItensVenda");
                });

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.ItemVenda", b =>
                {
                    b.HasOne("LojasAlternativas.QuickBuyBeta.Domain.Entity.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LojasAlternativas.QuickBuyBeta.Domain.Entity.Venda")
                        .WithMany("Itens")
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("LojasAlternativas.QuickBuyBeta.Domain.Entity.Venda", b =>
                {
                    b.HasOne("LojasAlternativas.QuickBuyBeta.Domain.Entity.Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}