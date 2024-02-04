using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RentCarProject.Models;

public partial class RentCarContext : DbContext
{
    public RentCarContext()
    {
    }

    public RentCarContext(DbContextOptions<RentCarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Devolucion> Devolucions { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Inspeccion> Inspeccions { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Rentum> Renta { get; set; }

    public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; }

    public virtual DbSet<TiposVehiculo> TiposVehiculos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLlocalDB;Database=RentCar;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cliente");

            entity.Property(e => e.NoTarjetaCr).HasColumnName("No.TarjetaCR");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Devolucion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Devolucion");

            entity.Property(e => e.Comentario)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NoRenta).HasColumnName("No.Renta");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cedula).HasColumnName("cedula");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TandaLaboral)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Inspeccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Inspeccion");

            entity.Property(e => e.Ralladuras)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rentum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NoRenta).HasColumnName("No.Renta");
        });

        modelBuilder.Entity<TipoCombustible>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TipoCombustible");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiposVehiculo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NoChasis).HasColumnName("No.Chasis");
            entity.Property(e => e.NoMotor).HasColumnName("No.Motor");
            entity.Property(e => e.NoPlaca).HasColumnName("No.Placa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
