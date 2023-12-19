using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class RisbergsMysigaBokhandelContext : DbContext
{
    public RisbergsMysigaBokhandelContext()
    {
    }

    public RisbergsMysigaBokhandelContext(DbContextOptions<RisbergsMysigaBokhandelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Butiker> Butikers { get; set; }

    public virtual DbSet<Böcker> Böckers { get; set; }

    public virtual DbSet<Författare> Författares { get; set; }

    public virtual DbSet<Kunder> Kunders { get; set; }

    public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }

    public virtual DbSet<OrderDetaljer> OrderDetaljers { get; set; }

    public virtual DbSet<Ordrar> Ordrars { get; set; }

    public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattares { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=R15;Initial Catalog=RisbergsMysigaBokhandel;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Butiker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Butiker__3214EC07C5E8A464");

            entity.ToTable("Butiker");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Böcker>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Böcker__447D36EB11BEA1C9");

            entity.ToTable("Böcker");

            entity.Property(e => e.Isbn)
                .ValueGeneratedNever()
                .HasColumnName("ISBN");
            entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

            entity.HasOne(d => d.Författare).WithMany(p => p.Böckers)
                .HasForeignKey(d => d.FörfattareId)
                .HasConstraintName("FK__Böcker__Författa__3E52440B");
        });

        modelBuilder.Entity<Författare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Författa__3214EC07EB9E41D1");

            entity.ToTable("Författare");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of Birth");
            entity.Property(e => e.DateOfDeath).HasColumnName("Date of death");
        });

        modelBuilder.Entity<Kunder>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Kunder__A4AE64D8287F04A5");

            entity.ToTable("Kunder");
        });

        modelBuilder.Entity<LagerSaldo>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.Isbn }).HasName("SaldoID");

            entity.ToTable("LagerSaldo");

            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.LagerSaldos)
                .HasForeignKey(d => d.Isbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LagerSaldo__ISBN__440B1D61");

            entity.HasOne(d => d.Store).WithMany(p => p.LagerSaldos)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LagerSald__Store__4316F928");
        });

        modelBuilder.Entity<OrderDetaljer>(entity =>
        {
            entity.HasKey(e => new { e.Isbn, e.OrderId });

            entity.ToTable("OrderDetaljer");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.OrderDetaljers)
                .HasForeignKey(d => d.Isbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ISBN_Böcker");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetaljers)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderId_Ordrar");
        });

        modelBuilder.Entity<Ordrar>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Ordrar__C3905BAF732807F8");

            entity.ToTable("Ordrar");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");

            entity.HasOne(d => d.Butik).WithMany(p => p.Ordrars)
                .HasForeignKey(d => d.ButikId)
                .HasConstraintName("FK__Ordrar__ButikId__4CA06362");

            entity.HasOne(d => d.Customer).WithMany(p => p.Ordrars)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Ordrar__Customer__4BAC3F29");
        });

        modelBuilder.Entity<TitlarPerFörfattare>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Titlar_Per_Författare");

            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
