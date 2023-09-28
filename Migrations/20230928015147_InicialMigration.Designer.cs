﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto1.Models;

#nullable disable

namespace Proyecto1.Migrations
{
    [DbContext(typeof(LibrosContext))]
    [Migration("20230928015147_InicialMigration")]
    partial class InicialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto1.Models.Alquilar", b =>
                {
                    b.Property<int>("IdAlquilar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlquilar"));

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCuenta")
                        .HasColumnType("int");

                    b.Property<int>("NumDias")
                        .HasColumnType("int");

                    b.HasKey("IdAlquilar");

                    b.ToTable("Alquilars");
                });

            modelBuilder.Entity("Proyecto1.Models.Comprar", b =>
                {
                    b.Property<int>("IdComprar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComprar"));

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCuenta")
                        .HasColumnType("int");

                    b.HasKey("IdComprar");

                    b.ToTable("Comprars");
                });

            modelBuilder.Entity("Proyecto1.Models.Publicar", b =>
                {
                    b.Property<int>("IdPublicar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPublicar"));

                    b.Property<string>("AutorLibro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caracteristicas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditorialLibro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreLibro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumPag")
                        .HasColumnType("int");

                    b.HasKey("IdPublicar");

                    b.ToTable("Publicars");
                });

            modelBuilder.Entity("Proyecto1.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FechaNacimiento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
