﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using servicioApi.data;

#nullable disable

namespace servicioApi.Migrations
{
    [DbContext(typeof(CiudadanoDBContext))]
    partial class CiudadanoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("servicioApi.model.Ciudadano", b =>
                {
                    b.Property<int>("ciudadano_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ciudadano_id"));

                    b.Property<string>("ciudadano_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudadano_cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudadano_celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudadano_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ciudadano_estado")
                        .HasColumnType("int");

                    b.Property<string>("ciudadano_fechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudadano_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ciudadano_id");

                    b.ToTable("Ciudadano");
                });
#pragma warning restore 612, 618
        }
    }
}
