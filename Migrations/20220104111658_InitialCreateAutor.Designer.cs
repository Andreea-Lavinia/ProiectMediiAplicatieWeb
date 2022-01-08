﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMediiAplicatieWeb.Data;

namespace ProiectMediiAplicatieWeb.Migrations
{
    [DbContext(typeof(ProiectMediiAplicatieWebContext))]
    [Migration("20220104111658_InitialCreateAutor")]
    partial class InitialCreateAutor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectMediiAplicatieWeb.Models.Autor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume_Autor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("ProiectMediiAplicatieWeb.Models.Carte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutorID")
                        .HasColumnType("int");

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume_Carte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pagini")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.ToTable("Carte");
                });

            modelBuilder.Entity("ProiectMediiAplicatieWeb.Models.Carte", b =>
                {
                    b.HasOne("ProiectMediiAplicatieWeb.Models.Autor", "Autor")
                        .WithMany("Books")
                        .HasForeignKey("AutorID");

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("ProiectMediiAplicatieWeb.Models.Autor", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
