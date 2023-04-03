﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercicio_semana9.Models;

#nullable disable

namespace exercicio_semana9.Migrations
{
    [DbContext(typeof(SemanaContext))]
    partial class SemanaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exercicio_semana9.Models.SemanaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Semana");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AplicadoConteudo")
                        .HasColumnType("bit");

                    b.Property<string>("Conteudo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataSemana9")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SEMANA");
                });
#pragma warning restore 612, 618
        }
    }
}
