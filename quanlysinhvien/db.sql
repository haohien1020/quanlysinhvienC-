USE QuanLySinhVien
CREATE TABLE SinhVien (
    ID INT IDENTITY(1,1) PRIMARY KEY, -- ID t? t?ng
    HoTen NVARCHAR(100) NOT NULL,     -- H? và tên
    NgaySinh DATE,                    -- Ngày sinh
    Lop NVARCHAR(50),                  -- L?p h?c
    DiaChi NVARCHAR(255),              -- ??a ch?
    Email NVARCHAR(100) UNIQUE NOT NULL, -- Email (không trùng nhau)
    Pass NVARCHAR(255) NOT NULL        -- M?t kh?u (có th? mã hóa sau)
);
