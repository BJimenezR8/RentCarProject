﻿using System;
using System.Collections.Generic;
using ASP.NETCoreIdentityCustom.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static RentCarProject.Data.DataRentCarProjectContext;

namespace RentCarProject.Models;

public partial class RentCarProjectContext : DbContext
{
    public RentCarProjectContext()
    {
    }

    public RentCarProjectContext(DbContextOptions<RentCarProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Combustible> Combustibles { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        *//*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost; database=RentCarProject; integrated security=true; TrustServerCertificate=Yes");
*//*

    }*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Combustible>(entity =>
        {
            entity.ToTable("Combustible");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);

        }
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
