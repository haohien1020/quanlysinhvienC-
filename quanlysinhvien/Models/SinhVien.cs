using System;
using System.Collections.Generic;

namespace quanlysinhvien.Models;

public partial class SinhVien
{
    public int Id { get; set; }

    public string HoTen { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public string? Lop { get; set; }

    public string? DiaChi { get; set; }

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;
}
