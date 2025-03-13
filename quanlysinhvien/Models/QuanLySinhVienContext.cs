using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace quanlysinhvien.Models;

public partial class QuanLySinhVienContext : DbContext
{
    public QuanLySinhVienContext()
    {
    }

    public QuanLySinhVienContext(DbContextOptions<QuanLySinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SinhVien__3214EC271485DDB6");

            entity.ToTable("SinhVien");

            entity.HasIndex(e => e.Email, "UQ__SinhVien__A9D105341063733A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.Lop).HasMaxLength(50);
            entity.Property(e => e.Pass).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
