USE QuanLySinhVien
CREATE TABLE SinhVien (
    ID INT IDENTITY(1,1) PRIMARY KEY, -- ID t? t?ng
    HoTen NVARCHAR(100) NOT NULL,     -- H? v� t�n
    NgaySinh DATE,                    -- Ng�y sinh
    Lop NVARCHAR(50),                  -- L?p h?c
    DiaChi NVARCHAR(255),              -- ??a ch?
    Email NVARCHAR(100) UNIQUE NOT NULL, -- Email (kh�ng tr�ng nhau)
    Pass NVARCHAR(255) NOT NULL        -- M?t kh?u (c� th? m� h�a sau)
);
