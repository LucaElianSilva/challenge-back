﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using challenge_back.Models;

#nullable disable

namespace challengeback.Migrations
{
    [DbContext(typeof(ChallengeContext))]
    partial class ChallengeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("challenge_back.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Categoria")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("FechaCarga")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = (byte)0,
                            FechaCarga = new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6371),
                            Nombre = "Prod 1",
                            Precio = 5
                        },
                        new
                        {
                            Id = 2,
                            Categoria = (byte)1,
                            FechaCarga = new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6387),
                            Nombre = "Prod 2",
                            Precio = 10
                        },
                        new
                        {
                            Id = 3,
                            Categoria = (byte)0,
                            FechaCarga = new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6388),
                            Nombre = "Prod 3",
                            Precio = 15
                        },
                        new
                        {
                            Id = 4,
                            Categoria = (byte)1,
                            FechaCarga = new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6390),
                            Nombre = "Prod 4",
                            Precio = 20
                        },
                        new
                        {
                            Id = 5,
                            Categoria = (byte)0,
                            FechaCarga = new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6391),
                            Nombre = "Prod 5",
                            Precio = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
