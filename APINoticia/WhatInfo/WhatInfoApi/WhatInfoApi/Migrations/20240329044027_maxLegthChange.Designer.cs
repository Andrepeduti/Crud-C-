﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhatInfoApi.Context;

#nullable disable

namespace WhatInfoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240329044027_maxLegthChange")]
    partial class maxLegthChange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("WhatInfoApi.models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("CategoriaName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WhatInfoApi.models.Noticia", b =>
                {
                    b.Property<int>("NoticiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("NoticiaId"));

                    b.Property<DateTime>("NoticiaData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NoticiaDescricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NoticiaLocal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NoticiaTitulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PublicadorNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("categoriaId")
                        .HasColumnType("int");

                    b.HasKey("NoticiaId");

                    b.HasIndex("categoriaId");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("WhatInfoApi.models.Noticia", b =>
                {
                    b.HasOne("WhatInfoApi.models.Categoria", "Categoria")
                        .WithMany("Noticia")
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("WhatInfoApi.models.Categoria", b =>
                {
                    b.Navigation("Noticia");
                });
#pragma warning restore 612, 618
        }
    }
}
