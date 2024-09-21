CREATE DATABASE QuanLyTrangTrai;
GO
USE QuanLyTrangTrai;
GO
CREATE TABLE GiaSuc (
    Id INT PRIMARY KEY IDENTITY(1,1),      -- C?t Id là khóa chính và t? ??ng t?ng
    LoaiGiaSuc NVARCHAR(50),               -- Lo?i gia súc (Bò, C?u, Dê, ...)
    SoLuong INT,                           -- S? l??ng gia súc ban ??u
    SoLuongSua FLOAT,                      -- L??ng s?a gia súc cho
    SoLuongCon INT                         -- S? l??ng con sinh ra
);
GO