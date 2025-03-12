using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TU4QVK7\\SQLEXPRESS;uid=sa;pwd=12345678;database=QuanLySinhVien;Integrated Security=true;TrustServerCertificate=Yes");

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
