USE [master]
GO
/****** Object:  Database [NhaHangHan]    Script Date: 01/12/2017 19:14:32 ******/
CREATE DATABASE [NhaHangHan] ON  PRIMARY 
( NAME = N'NhaHangHan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\NhaHangHan.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NhaHangHan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\NhaHangHan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NhaHangHan] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NhaHangHan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NhaHangHan] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [NhaHangHan] SET ANSI_NULLS OFF
GO
ALTER DATABASE [NhaHangHan] SET ANSI_PADDING OFF
GO
ALTER DATABASE [NhaHangHan] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [NhaHangHan] SET ARITHABORT OFF
GO
ALTER DATABASE [NhaHangHan] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [NhaHangHan] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [NhaHangHan] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [NhaHangHan] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [NhaHangHan] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [NhaHangHan] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [NhaHangHan] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [NhaHangHan] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [NhaHangHan] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [NhaHangHan] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [NhaHangHan] SET  DISABLE_BROKER
GO
ALTER DATABASE [NhaHangHan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [NhaHangHan] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [NhaHangHan] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [NhaHangHan] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [NhaHangHan] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [NhaHangHan] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [NhaHangHan] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [NhaHangHan] SET  READ_WRITE
GO
ALTER DATABASE [NhaHangHan] SET RECOVERY FULL
GO
ALTER DATABASE [NhaHangHan] SET  MULTI_USER
GO
ALTER DATABASE [NhaHangHan] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [NhaHangHan] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'NhaHangHan', N'ON'
GO
USE [NhaHangHan]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoNV] [nvarchar](50) NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaysinhNV] [datetime] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](50) NULL,
	[Chucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [TenNV], [NgaysinhNV], [Diachi], [Dienthoai], [Chucvu]) VALUES (1, N'Trần Nhật', N'Quang', CAST(0x00008A1800000000 AS DateTime), N'Long An', N'01655220769', N'Quản Lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [TenNV], [NgaysinhNV], [Diachi], [Dienthoai], [Chucvu]) VALUES (2, N'Mai Cẩm', N'Nhi', CAST(0x000087CF00000000 AS DateTime), N'TP.HCM', N'123456789', N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoaiSP] ON
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (1, N'Cơm')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoaiSP]) VALUES (2, N'Fast Food')
SET IDENTITY_INSERT [dbo].[LoaiSP] OFF
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoKH] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Ngaysinh], [Diachi], [Dienthoai]) VALUES (1, N'Mai Cẩm', N'Nhi', CAST(0x000087CF00000000 AS DateTime), N'TP.HCM', N'19288912')
INSERT [dbo].[KhachHang] ([MaKH], [HoKH], [TenKH], [Ngaysinh], [Diachi], [Dienthoai]) VALUES (2, N'Nguyễn Dư Phúc', N'Hảo', CAST(0x0000A6EA00D9F1F7 AS DateTime), N'TP.HCM', N'12345')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
/****** Object:  Table [dbo].[SanPham]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](4) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[Donvitinh] [nvarchar](10) NULL,
	[Dongia] [float] NULL,
	[MaLoaiSP] [int] NOT NULL,
	[HinhSP] [nvarchar](max) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Donvitinh], [Dongia], [MaLoaiSP], [HinhSP]) VALUES (N'1', N'Cơm cuộn', N'dĩa', 35000, 1, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Donvitinh], [Dongia], [MaLoaiSP], [HinhSP]) VALUES (N'2', N'Toppoki', N'dĩa', 45000, 1, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Donvitinh], [Dongia], [MaLoaiSP], [HinhSP]) VALUES (N'3', N'Cá viên chiên', N'xiên', 5000, 2, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Donvitinh], [Dongia], [MaLoaiSP], [HinhSP]) VALUES (N'4', N'Bò viên chiên', N'xiên', 5000, 2, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [Donvitinh], [Dongia], [MaLoaiSP], [HinhSP]) VALUES (N'5', N'Cơm trộn', N'dĩa', 25000, 1, NULL)
/****** Object:  Table [dbo].[HoaDon]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] NOT NULL,
	[MaKH] [int] NULL,
	[MaNV] [int] NULL,
	[NgayLapHD] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD]) VALUES (1, 1, 1, CAST(0x0000A6E801638841 AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD]) VALUES (2, 1, 1, CAST(0x0000A6EB01638804 AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD]) VALUES (3, 1, 2, CAST(0x0000A6EA00F721C6 AS DateTime))
/****** Object:  Table [dbo].[CTDH]    Script Date: 01/12/2017 19:14:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDH](
	[MaHD] [int] NOT NULL,
	[MaSP] [nvarchar](4) NOT NULL,
	[Soluong] [smallint] NULL,
 CONSTRAINT [PK_CTDH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTDH] ([MaHD], [MaSP], [Soluong]) VALUES (1, N'1', 1)
INSERT [dbo].[CTDH] ([MaHD], [MaSP], [Soluong]) VALUES (1, N'3', 2)
INSERT [dbo].[CTDH] ([MaHD], [MaSP], [Soluong]) VALUES (2, N'3', 3)
INSERT [dbo].[CTDH] ([MaHD], [MaSP], [Soluong]) VALUES (2, N'5', 2)
/****** Object:  ForeignKey [FK_SanPham_LoaiSP]    Script Date: 01/12/2017 19:14:35 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
/****** Object:  ForeignKey [FK_HoaDon_KhachHang]    Script Date: 01/12/2017 19:14:35 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien]    Script Date: 01/12/2017 19:14:35 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  ForeignKey [FK_CTDH_HoaDon]    Script Date: 01/12/2017 19:14:35 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_HoaDon]
GO
/****** Object:  ForeignKey [FK_CTDH_SanPham]    Script Date: 01/12/2017 19:14:35 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_SanPham]
GO
