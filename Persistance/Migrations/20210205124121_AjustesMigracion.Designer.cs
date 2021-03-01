﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

namespace Persistance.Migrations
{
    [DbContext(typeof(FormularioContext))]
    [Migration("20210205124121_AjustesMigracion")]
    partial class AjustesMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.FormularioDesperfectoMovil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desperfecto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscInsId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<short>("MovCod")
                        .HasColumnType("smallint");

                    b.Property<int>("MovilKilometraje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FormularioDesperfectoMovil");
                });

            modelBuilder.Entity("Models.FormularioDiarioMovil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Combustible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscInsId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("LucesDelanterasCortasDerecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesDelanterasCortasIzquierda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesDelanterasLargasDerecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesDelanterasLargasIzquierda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesDelanterasSenialeroDerecho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesDelanterasSenialeroIzquierdo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasFreno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasPosicionDerecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasPosicionIzquierda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasReversa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasSenialeroDerecho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LucesTracerasSenialeroIzquierdo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("MovCod")
                        .HasColumnType("smallint");

                    b.Property<int>("MovilKilometraje")
                        .HasColumnType("int");

                    b.Property<string>("NivelAceite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelAgua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjetoAuxiliar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjetoBaliza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjetoConos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjetoExtintor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormularioDiarioMovil");
                });
#pragma warning restore 612, 618
        }
    }
}