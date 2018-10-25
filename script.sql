create database QuanLyDiem
go
use QuanLyDiem
go
-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************

-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************



-- ************************************** [NhanVienDaoTao]

CREATE TABLE [NhanVienDaoTao]
(
 [MaNVDT]  NCHAR(50) NOT NULL ,
 [TenNVDT] NVARCHAR(255) NOT NULL ,

 CONSTRAINT [PK_NhanVienDaoTao] PRIMARY KEY CLUSTERED ([MaNVDT] ASC)
);
GO





-- ************************************** [dbo].[DangNhap]

CREATE TABLE [dbo].[DangNhap]
(
 [ID]           CHAR(50) NOT NULL ,
 [TenHienThi]   NVARCHAR(255) NULL ,
 [Password]     NVARCHAR(50) NOT NULL ,
 [LoaiTaiKhoan] NVARCHAR(255) NOT NULL ,

 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED ([ID] ASC)
);
GO





-- ************************************** [dbo].[HocKy]

CREATE TABLE [dbo].[HocKy]
(
 [MaHK]      NCHAR(50) NOT NULL ,
 [TenHK]     NVARCHAR(255) NULL ,
 [TGBatDau]  DATETIME NULL ,
 [TGKetThuc] DATETIME NULL ,
 [NamHoc]    INT NULL ,

 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED ([MaHK] ASC)
);
GO





-- ************************************** [dbo].[Khoa]

CREATE TABLE [dbo].[Khoa]
(
 [MaKhoa]  NCHAR(50) NOT NULL ,
 [TenKhoa] NVARCHAR(255)	 NOT NULL ,

 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED ([MaKhoa] ASC)
);
GO





-- ************************************** [dbo].[HocPhan]

CREATE TABLE [dbo].[HocPhan]
(
 [MaHP]        NCHAR(50) NOT NULL ,
 [TenHP]       NVARCHAR(255) NOT NULL ,
 [SoTC]        INT NULL ,
 [SoTietTH]    INT NULL ,
 [SoTietLT]    INT NULL ,
 [PhanTramDKT] FLOAT NULL ,
 [PhanTramDT]  FLOAT NULL ,

 CONSTRAINT [PK_HocPhan] PRIMARY KEY CLUSTERED ([MaHP] ASC)
);
GO





-- ************************************** [dbo].[GiangVien]

CREATE TABLE [dbo].[GiangVien]
(
 [MaGV]   CHAR(50) NOT NULL ,
 [TenGV]  NVARCHAR(255)	 NOT NULL ,
 [MaKhoa] NCHAR(50) NOT NULL ,

 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED ([MaGV] ASC),
 CONSTRAINT [FK_76] FOREIGN KEY ([MaKhoa])
  REFERENCES [dbo].[Khoa]([MaKhoa])
);
GO


--SKIP Index: [fkIdx_76]




-- ************************************** [dbo].[ChuyenNganh]

CREATE TABLE [dbo].[ChuyenNganh]
(
 [MaCN]   NCHAR(50) NOT NULL ,
 [TenCN]  NVARCHAR(255) NOT NULL ,
 [MaKhoa] NCHAR(50) NOT NULL ,

 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED ([MaCN] ASC),
 CONSTRAINT [FK_73] FOREIGN KEY ([MaKhoa])
  REFERENCES [dbo].[Khoa]([MaKhoa])
);
GO


--SKIP Index: [fkIdx_73]




-- ************************************** [LopHocPhan]

CREATE TABLE [LopHocPhan]
(
 [MaNhomHP]  NCHAR(50) NOT NULL ,
 [TenNhomHP] NVARCHAR(255)	 NOT NULL ,
 [MaHP]      NCHAR(50) NOT NULL ,
 [MaGV]      CHAR(50) NOT NULL ,
 [MaHK]      NCHAR(50) NOT NULL ,

 CONSTRAINT [PK_NhomHocPhan] PRIMARY KEY CLUSTERED ([MaNhomHP] ASC),
 CONSTRAINT [FK_83] FOREIGN KEY ([MaHP])
  REFERENCES [dbo].[HocPhan]([MaHP]),
 CONSTRAINT [FK_89] FOREIGN KEY ([MaGV])
  REFERENCES [dbo].[GiangVien]([MaGV]),
 CONSTRAINT [FK_109] FOREIGN KEY ([MaHK])
  REFERENCES [dbo].[HocKy]([MaHK])
);
GO


--SKIP Index: [fkIdx_83]

--SKIP Index: [fkIdx_89]

--SKIP Index: [fkIdx_109]




-- ************************************** [dbo].[Lop]

CREATE TABLE [dbo].[Lop]
(
 [MaLop]  CHAR(50) NOT NULL ,
 [TenLop] NVARCHAR(255) NOT NULL ,
 [MaGV]   CHAR(50) NOT NULL ,
 [MaCN]   NCHAR(50) NOT NULL ,

 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED ([MaLop] ASC),
 CONSTRAINT [FK_57] FOREIGN KEY ([MaGV])
  REFERENCES [dbo].[GiangVien]([MaGV]),
 CONSTRAINT [FK_63] FOREIGN KEY ([MaCN])
  REFERENCES [dbo].[ChuyenNganh]([MaCN])
);
GO


--SKIP Index: [fkIdx_57]

--SKIP Index: [fkIdx_63]




-- ************************************** [dbo].[HocVien]

CREATE TABLE [dbo].[HocVien]
(
 [MaHV]     CHAR(50) NOT NULL ,
 [HoTen]    NVARCHAR(255) NOT NULL ,
 [DiaChi]   NVARCHAR(255) NULL ,
 [NgaySinh] DATE NULL ,
 [MaLop]    CHAR(50) NOT NULL ,

 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([MaHV] ASC),
 CONSTRAINT [FK_60] FOREIGN KEY ([MaLop])
  REFERENCES [dbo].[Lop]([MaLop])
);
GO


--SKIP Index: [fkIdx_60]




-- ************************************** [dbo].[KetQuaHocPhan]

CREATE TABLE [dbo].[KetQuaHocPhan]
(
 [DiemBT]   FLOAT NULL ,
 [DiemGK]   FLOAT NULL ,
 [DiemThi]  FLOAT NULL ,
 [MaHV]     CHAR(50) NOT NULL ,
 [MaNhomHP] NCHAR(50) NOT NULL ,

 CONSTRAINT [FK_66] FOREIGN KEY ([MaHV])
  REFERENCES [dbo].[HocVien]([MaHV]),
 CONSTRAINT [FK_86] FOREIGN KEY ([MaNhomHP])
  REFERENCES [LopHocPhan]([MaNhomHP])
);
GO


--SKIP Index: [fkIdx_66]

--SKIP Index: [fkIdx_86]









