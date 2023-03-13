using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Computer_Store.Entities;

public partial class StoreDBContext : DbContext
{
    public StoreDBContext()
    {
    }

    public StoreDBContext(DbContextOptions<StoreDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ItemDetail> ItemDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DHRUV\\SQLEXPRESS;Database=Dhruv_Database;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemDetail>(entity =>
        {
            entity.ToTable("ItemDetail");

            entity.Property(e => e.Company)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Hardisk)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Os)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OS");
            entity.Property(e => e.Product_Name)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Product_Name");
            entity.Property(e => e.ProductType)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
