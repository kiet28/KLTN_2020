USE [master]
GO
/****** Object:  Database [Nhom14_QLKhachSan_version_1]    Script Date: 5/24/2020 3:04:07 PM ******/
CREATE DATABASE [Nhom14_QLKhachSan_version_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhom14_QLKhachSan_version_1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Nhom14_QLKhachSan_version_1.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Nhom14_QLKhachSan_version_1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Nhom14_QLKhachSan_version_1_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhom14_QLKhachSan_version_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET  MULTI_USER 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Nhom14_QLKhachSan_version_1]
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[maCTHD] [int] IDENTITY(1,1) NOT NULL,
	[ngayTraPhong] [date] NULL,
	[maPhong] [int] NULL,
	[maHD] [int] NULL,
	[maThuePhong] [int] NULL,
	[maDV] [int] NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED 
(
	[maCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTThuePhong]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTThuePhong](
	[maThuePhong] [int] IDENTITY(1,1) NOT NULL,
	[maPhong] [int] NOT NULL,
	[maDichVu] [int] NULL,
	[DVT] [nvarchar](15) NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_CTThuePhong] PRIMARY KEY CLUSTERED 
(
	[maThuePhong] ASC,
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[maDichVu] [int] IDENTITY(1,1) NOT NULL,
	[tenDichVu] [nvarchar](50) NULL,
	[giaDichVu] [money] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[maDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [int] IDENTITY(1,1) NOT NULL,
	[maNhanVien] [int] NULL,
	[ngayLapHD] [date] NULL,
	[tongTien] [money] NULL,
	[maKhachHang] [int] NULL,
	[maThuePhong] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[CMND] [nvarchar](15) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[SDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiQuanLy]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiQuanLy](
	[maNQL] [int] IDENTITY(1,1) NOT NULL,
	[tenNQL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiQuanLy] PRIMARY KEY CLUSTERED 
(
	[maNQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[namSinh] [date] NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[diaChi] [nvarchar](150) NULL,
	[SDT] [nvarchar](15) NULL,
	[trangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[maPhong] [int] IDENTITY(1,1) NOT NULL,
	[tenPhong] [nvarchar](50) NULL,
	[trangThai] [int] NULL,
	[ghiChu] [nvarchar](150) NULL,
	[giaPhong] [money] NULL,
	[loaiPhong] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[maTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NOT NULL,
	[maNhanVien] [int] NULL,
	[maNQL] [int] NULL,
	[loaiTaiKhoan] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[maTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 5/24/2020 3:04:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[maThuePhong] [int] IDENTITY(1,1) NOT NULL,
	[maNhanVien] [int] NULL,
	[maKhachHang] [int] NULL,
	[ngayThuePhong] [date] NULL,
	[ngayTraPhong] [date] NULL,
	[gioThue] [nvarchar](10) NULL,
	[gioTra] [nvarchar](10) NULL,
 CONSTRAINT [PK_ThuePhong] PRIMARY KEY CLUSTERED 
(
	[maThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY([maHD])
REFERENCES [dbo].[HoaDon] ([maHD])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_Phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_Phong]
GO
ALTER TABLE [dbo].[CTThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_CTThuePhong_DichVu] FOREIGN KEY([maDichVu])
REFERENCES [dbo].[DichVu] ([maDichVu])
GO
ALTER TABLE [dbo].[CTThuePhong] CHECK CONSTRAINT [FK_CTThuePhong_DichVu]
GO
ALTER TABLE [dbo].[CTThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_CTThuePhong_Phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[CTThuePhong] CHECK CONSTRAINT [FK_CTThuePhong_Phong]
GO
ALTER TABLE [dbo].[CTThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_CTThuePhong_ThuePhong] FOREIGN KEY([maThuePhong])
REFERENCES [dbo].[ThuePhong] ([maThuePhong])
GO
ALTER TABLE [dbo].[CTThuePhong] CHECK CONSTRAINT [FK_CTThuePhong_ThuePhong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ThuePhong] FOREIGN KEY([maThuePhong])
REFERENCES [dbo].[ThuePhong] ([maThuePhong])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_ThuePhong]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NguoiQuanLy] FOREIGN KEY([maNQL])
REFERENCES [dbo].[NguoiQuanLy] ([maNQL])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NguoiQuanLy]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KhachHang]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [Nhom14_QLKhachSan_version_1] SET  READ_WRITE 
GO
