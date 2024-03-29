﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Saltie_Backend.Data;

#nullable disable

namespace Saltie_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Saltie_Backend.Models.ItemPedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Pedidoid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("produtoid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("qtd")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Pedidoid");

                    b.HasIndex("produtoid");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("qtd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("usuarioid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("usuarioid");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Tipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cargo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Vinho", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("qtd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tipoid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("tipoid");

                    b.ToTable("Vinhos");
                });

            modelBuilder.Entity("Saltie_Backend.Models.ItemPedido", b =>
                {
                    b.HasOne("Saltie_Backend.Models.Pedido", null)
                        .WithMany("item")
                        .HasForeignKey("Pedidoid");

                    b.HasOne("Saltie_Backend.Models.Vinho", "produto")
                        .WithMany()
                        .HasForeignKey("produtoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("produto");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Pedido", b =>
                {
                    b.HasOne("Saltie_Backend.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Vinho", b =>
                {
                    b.HasOne("Saltie_Backend.Models.Tipo", "tipo")
                        .WithMany()
                        .HasForeignKey("tipoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipo");
                });

            modelBuilder.Entity("Saltie_Backend.Models.Pedido", b =>
                {
                    b.Navigation("item");
                });
#pragma warning restore 612, 618
        }
    }
}
