﻿// <auto-generated />
using Jean_P1_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jean_P1_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201005231945_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Jean_P1_AP1.Entities.Ciudad", b =>
                {
                    b.Property<int>("CiudadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("CiudadID");

                    b.ToTable("Ciudades");
                });
#pragma warning restore 612, 618
        }
    }
}