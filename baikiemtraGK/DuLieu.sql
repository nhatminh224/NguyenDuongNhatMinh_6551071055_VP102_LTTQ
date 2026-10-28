CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

IF OBJECT_ID('SinhVien', 'U') IS NOT NULL
    DROP TABLE SinhVien;
GO

CREATE TABLE SinhVien (
    MaSinhVien nvarchar(10) PRIMARY KEY,
    TenSinhVien nText NOT NULL,
    DiemTrungBinh nvarchar(8) NOT NULL
);
GO

INSERT INTO SinhVien (MaSinhVien, TenSinhVien, DiemTrungBinh) VALUES
(N'SV001', N'Nguyễn Văn A', N'8.5'),
(N'SV002', N'Trần Thị B', N'7.0'),
(N'SV003', N'Lê Văn C', N'9.0'),
(N'SV004', N'Phạm Thị D', N'6.5'),
(N'SV005', N'Hoàng Văn E', N'8.0');
GO
