using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CA_Motorcycle.Models;

public partial class MotorcycleDbContext : DbContext
{
    public MotorcycleDbContext()
    {
    }

    public MotorcycleDbContext(DbContextOptions<MotorcycleDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Motorcycle> Motorcycles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-R1GI7QV\\SQLEXPRESS;database=MotorcycleDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Motorcycle>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Colour).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
