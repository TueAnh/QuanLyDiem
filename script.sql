drop database QuanLyDiem
go
create database QuanLyDiem
go
use QuanLyDiem
go
-- ****************** SqlDBM: Microsoft SQL Server ******************
-- ******************************************************************



-- ************************************** [dbo].[Users]

CREATE TABLE [dbo].[Users]
(
 [ID]        nchar(50) NOT NULL ,
 [HoTen]     nvarchar(255) NOT NULL ,
 [Email]     nvarchar(50) NULL ,
 [DiaChi]    nvarchar(255) NULL ,
 [DienThoai] char(12) NULL ,
 [Password]  nchar(10) NOT NULL ,
 [NgaySinh]  date NULL ,

 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([ID] ASC)
);
GO








-- ************************************** [dbo].[Khoa]

CREATE TABLE [dbo].[Khoa]
(
 [MaKhoa]  nchar(50) NOT NULL ,
 [TenKhoa] nvarchar(255)	 NOT NULL ,

 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED ([MaKhoa] ASC)
);
GO








-- ************************************** [dbo].[HocKy]

CREATE TABLE [dbo].[HocKy]
(
 [MaHK]      nchar(50) NOT NULL ,
 [TenHK]     nvarchar(255) NULL ,
 [TGBatDau]  datetime NULL ,
 [TGKetThuc] datetime NULL ,
 [NamHoc]    int NULL ,

 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED ([MaHK] ASC)
);
GO








-- ************************************** [dbo].[NhanVienDaoTao]

CREATE TABLE [dbo].[NhanVienDaoTao]
(
 [ID] nchar(50) NOT NULL ,

 CONSTRAINT [PK_NhanVienDaoTao] PRIMARY KEY CLUSTERED ([ID] ASC),
 CONSTRAINT [FK_143] FOREIGN KEY ([ID])  REFERENCES [dbo].[Users]([ID])
);
GO


--SKIP Index: [fkIdx_143]







-- ************************************** [dbo].[GiangVien]

CREATE TABLE [dbo].[GiangVien]
(
 [ID]     nchar(50) NOT NULL ,
 [MaKhoa] nchar(50) NOT NULL ,

 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED ([ID] ASC),
 CONSTRAINT [FK_146] FOREIGN KEY ([ID])  REFERENCES [dbo].[Users]([ID]),
 CONSTRAINT [FK_76] FOREIGN KEY ([MaKhoa])  REFERENCES [dbo].[Khoa]([MaKhoa])
);
GO


--SKIP Index: [fkIdx_146]

--SKIP Index: [fkIdx_76]







-- ************************************** [dbo].[ChuyenNganh]

CREATE TABLE [dbo].[ChuyenNganh]
(
 [MaCN]   nchar(50) NOT NULL ,
 [TenCN]  nvarchar(255) NOT NULL ,
 [MaKhoa] nchar(50) NOT NULL ,

 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED ([MaCN] ASC),
 CONSTRAINT [FK_73] FOREIGN KEY ([MaKhoa])  REFERENCES [dbo].[Khoa]([MaKhoa])
);
GO


--SKIP Index: [fkIdx_73]







-- ************************************** [dbo].[LopDaoTao]

CREATE TABLE [dbo].[LopDaoTao]
(
 [MaLop]  char(50) NOT NULL ,
 [TenLop] nvarchar(255) NOT NULL ,
 [MaCN]   nchar(50) NOT NULL ,

 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED ([MaLop] ASC),
 CONSTRAINT [FK_63] FOREIGN KEY ([MaCN])  REFERENCES [dbo].[ChuyenNganh]([MaCN])
);
GO


--SKIP Index: [fkIdx_63]







-- ************************************** [dbo].[HocPhan]

CREATE TABLE [dbo].[HocPhan]
(
 [MaHP]        nchar(50) NOT NULL ,
 [TenHP]       nvarchar(255) NOT NULL ,
 [SoTC]        int NULL ,
 [SoTietTH]    int NULL ,
 [SoTietLT]    int NULL ,
 [PhanTramDKT] float NULL ,
 [PhanTramDT]  float NULL ,
 [MaHK]        nchar(50) NOT NULL ,
 [ID]          nchar(50) NOT NULL ,

 CONSTRAINT [PK_NhomHocPhan] PRIMARY KEY CLUSTERED ([MaHP] ASC),
 CONSTRAINT [FK_109] FOREIGN KEY ([MaHK])  REFERENCES [dbo].[HocKy]([MaHK]),
 CONSTRAINT [FK_89] FOREIGN KEY ([ID])  REFERENCES [dbo].[GiangVien]([ID])
);
GO


--SKIP Index: [fkIdx_109]

--SKIP Index: [fkIdx_89]







-- ************************************** [dbo].[HocVien]

CREATE TABLE [dbo].[HocVien]
(
 [ID]    nchar(50) NOT NULL ,
 [MaLop] char(50) NOT NULL ,

 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([ID] ASC),
 CONSTRAINT [FK_149] FOREIGN KEY ([ID])  REFERENCES [dbo].[Users]([ID]),
 CONSTRAINT [FK_60] FOREIGN KEY ([MaLop])  REFERENCES [dbo].[LopDaoTao]([MaLop])
);
GO


--SKIP Index: [fkIdx_149]

--SKIP Index: [fkIdx_60]







-- ************************************** [dbo].[KetQuaHocPhan]

CREATE TABLE [dbo].[KetQuaHocPhan]
(
 [DiemBT]  float NULL ,
 [DiemGK]  float NULL ,
 [DiemThi] float NULL ,
 [MaHP]    nchar(50) NOT NULL ,
 [ID]      nchar(50) NOT NULL ,

 CONSTRAINT [FK_66] FOREIGN KEY ([ID])  REFERENCES [dbo].[HocVien]([ID]),
 CONSTRAINT [FK_86] FOREIGN KEY ([MaHP])  REFERENCES [dbo].[HocPhan]([MaHP])
);
GO


--SKIP Index: [fkIdx_66]

--SKIP Index: [fkIdx_86]


















