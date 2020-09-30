﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MimicAPI.Database;

namespace MimicAPI.Migrations
{
    [DbContext(typeof(MimicContext))]
    [Migration("20200930032556_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("MimicAPI.Models.Palavra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Atualizado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Criado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Palavras");
                });
#pragma warning restore 612, 618
        }
    }
}
