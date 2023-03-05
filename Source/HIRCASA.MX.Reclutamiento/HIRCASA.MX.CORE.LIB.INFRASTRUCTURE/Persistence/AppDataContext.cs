using System;
using System.Collections.Generic;
using HIRCASA.MX.CORE.LIB.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace HIRCASA.MX.CORE.LIB.INFRASTRUCTURE.Persistence;

public partial class AppDataContext : DbContext
{
    public AppDataContext()
    {
    }

    public AppDataContext(DbContextOptions<AppDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ajuste> Ajustes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=COR-L-AJCONTRER\\SQLEXPRESSVER13;initial catalog=ClientsHirCasaReclutamiento;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ajuste>(entity =>
        {
            entity.HasKey(e => e.AjusteId).HasName("PK_Ajuste");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Ajustes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ajuste_Clientes");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Telefono).IsFixedLength();
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Pagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pagos_Clientes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
