﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentCarProject.Models;

#nullable disable

namespace RentCarProject.Migrations
{
    [DbContext(typeof(RentCarProjectContext))]
    partial class RentCarProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP.NETCoreIdentityCustom.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("RentCarProject.Models.Combustible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Tipo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Combustible", (string)null);
                });

            modelBuilder.Entity("RentCarProject.Models.Devolucion", b =>
                {
                    b.Property<int?>("NoRenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("NoRenta"));

                    b.Property<int?>("CantidadDeDias")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("FechaDevolucion")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<int?>("MontoxDia")
                        .HasColumnType("int");

                    b.HasKey("NoRenta");

                    b.ToTable("Devolucion");
                });

            modelBuilder.Entity("RentCarProject.Models.Empleado", b =>
                {
                    b.Property<int?>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdEmpleado"));

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PorcientoComision")
                        .HasColumnType("int");

                    b.Property<string>("TandaLaboral")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("RentCarProject.Models.Inspeccion", b =>
                {
                    b.Property<int?>("IdTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdTransaccion"));

                    b.Property<int?>("CantidadCombustible")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoGomas")
                        .HasColumnType("int");

                    b.Property<int?>("GomaRepuesta")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdVehiculo")
                        .HasColumnType("int");

                    b.Property<string>("Ralladuras")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTransaccion");

                    b.ToTable("Inspeccion");
                });

            modelBuilder.Entity("RentCarProject.Models.LoginUsuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("LoginUsuario");
                });

            modelBuilder.Entity("RentCarProject.Models.Marca", b =>
                {
                    b.Property<int?>("IdMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdMarca"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMarca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("RentCarProject.Models.Modelo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdMarca")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("RentCarProject.Models.TipoCombustible", b =>
                {
                    b.Property<int?>("IdTipoCombustible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdTipoCombustible"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.HasKey("IdTipoCombustible");

                    b.ToTable("TipoCombustible");
                });

            modelBuilder.Entity("RentCarProject.Models.TiposVehiculo", b =>
                {
                    b.Property<int?>("IdTipoVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdTipoVehiculo"));

                    b.Property<int?>("Descripcion")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoVehiculo");

                    b.ToTable("TiposVehiculo");
                });

            modelBuilder.Entity("RentCarProject.Models.Vehiculo", b =>
                {
                    b.Property<int?>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdVehiculo"));

                    b.Property<int?>("Descripcion")
                        .HasColumnType("int");

                    b.Property<int?>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int?>("IdModelo")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoCombustible")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoVehiculo")
                        .HasColumnType("int");

                    b.Property<int?>("NoChasis")
                        .HasColumnType("int");

                    b.Property<int?>("NoMotor")
                        .HasColumnType("int");

                    b.Property<int?>("NoPlaca")
                        .HasColumnType("int");

                    b.HasKey("IdVehiculo");

                    b.ToTable("Vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
