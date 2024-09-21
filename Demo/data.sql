CREATE DATABASE QuanLyTrangTrai;
GO
USE QuanLyTrangTrai;
GO
CREATE TABLE GiaSuc (
    Id INT PRIMARY KEY IDENTITY(1,1),      -- C?t Id l� kh�a ch�nh v� t? ??ng t?ng
    LoaiGiaSuc NVARCHAR(50),               -- Lo?i gia s�c (B�, C?u, D�, ...)
    SoLuong INT,                           -- S? l??ng gia s�c ban ??u
    SoLuongSua FLOAT,                      -- L??ng s?a gia s�c cho
    SoLuongCon INT                         -- S? l??ng con sinh ra
);
GO