USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 2/8/2025 1:58:57 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSPML\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSPML\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyThuVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[tblPhieumuon]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieumuon](
	[sMaphieu] [varchar](10) NOT NULL,
	[sMadocgia] [varchar](10) NULL,
	[dNgaymuon] [date] NULL,
 CONSTRAINT [PK__tblPhieu__4C0CE13759D2DA94] PRIMARY KEY CLUSTERED 
(
	[sMaphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[sMadocgia] [varchar](10) NOT NULL,
	[sTendocgia] [nvarchar](50) NOT NULL,
	[dNgaysinh] [date] NOT NULL,
	[sGioitinh] [nvarchar](5) NOT NULL,
	[sEmail] [varchar](40) NULL,
	[sDiachi] [nvarchar](30) NOT NULL,
	[sSdt] [varchar](10) NOT NULL,
	[sMaloaidocgia] [varchar](10) NOT NULL,
	[dNgaylapthe] [date] NULL,
	[dNgayhethan] [date] NULL,
	[isDeleted] [bit] NULL,
 CONSTRAINT [PK__tblDocGi__E81196F2B75BD560] PRIMARY KEY CLUSTERED 
(
	[sMadocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__tblDocGi__3E35FAB576313BED] UNIQUE NONCLUSTERED 
(
	[sSdt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[sMasach] [varchar](10) NOT NULL,
	[sTensach] [nvarchar](30) NOT NULL,
	[sMatheloai] [varchar](10) NULL,
	[sNhaxuatban] [nvarchar](50) NOT NULL,
	[dNgaynhap] [date] NULL,
	[fDongia] [float] NULL,
	[iSNhap] [int] NOT NULL,
	[sTinhtrang] [nvarchar](5) NULL,
	[isDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTmuontra]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTmuontra](
	[sMaphieu] [varchar](10) NOT NULL,
	[sMasach] [varchar](10) NOT NULL,
	[dNgayhentra] [date] NULL,
	[iSlmuon] [int] NULL,
	[sGhichu] [nvarchar](50) NULL,
	[isDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaphieu] ASC,
	[sMasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_DSPMT]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[v_DSPMT]
As Select ct.sMaphieu as [Mã phiếu], dg.sMadocgia as [Mã độc giả], ct.sMasach as [Mã sách], 
iSlmuon as[SL], dNgaymuon as [Ngày mượn], dNgayhentra as [Ngày hẹn trả], sGhichu as [Ghi chú]
From tblCTmuontra ct
Join tblPhieumuon pm On pm.sMaphieu = ct.sMaphieu
Join tblSach s On s.sMasach = ct.sMasach
Join tblDocGia dg On pm.sMadocgia = dg.sMadocgia
Where ct.isDeleted = 0
GO
/****** Object:  View [dbo].[v_DSPM]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSPM]
AS
SELECT ct.sMaphieu AS [Mã phiếu], dg.sMadocgia AS [Mã độc giả], dg.sTendocgia AS [Tên độc giả], ct.sMasach AS [Mã sách], s.sTensach AS [Tên sách], ct.iSlmuon AS [SL mượn], pm.dNgaymuon AS [Ngày mượn], ct.dNgayhentra AS [Ngày hẹn trả], ct.sGhichu AS [Ghi chú]
FROM   dbo.tblCTmuontra AS ct INNER JOIN
           dbo.tblPhieumuon AS pm ON pm.sMaphieu = ct.sMaphieu INNER JOIN
           dbo.tblSach AS s ON s.sMasach = ct.sMasach INNER JOIN
           dbo.tblDocGia AS dg ON pm.sMadocgia = dg.sMadocgia
WHERE (ct.isDeleted = 0)
GO
/****** Object:  View [dbo].[v_DSS]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSS]
AS
SELECT sMasach AS [Mã sách], sTensach AS [Tên sách], sMatheloai AS [Mã thể loại], sNhaxuatban AS NXB, dNgaynhap AS [Ngày nhập], fDongia AS [Đơn giá], iSNhap AS [Số lượng], sTinhtrang AS [Tình trạng]
FROM   dbo.tblSach
WHERE (isDeleted = 0)
GO
/****** Object:  Table [dbo].[tblTheloai]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheloai](
	[sMatheloai] [varchar](10) NOT NULL,
	[sTentheloai] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sMatheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_BCTKSach_Theloai]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_BCTKSach_Theloai]
As
Select s.sMatheloai as [Mã thể loại],sTentheloai as [Tên thể loại], sum(iSlmuon) as [Số lượng mượn], CAST(SUM(iSlmuon) * 100.0 / SUM(SUM(iSlmuon)) OVER () AS DECIMAL(5, 2)) AS [Tỉ lệ (%)]
From tblCTmuontra pm
Join tblPhieumuon ct On pm.sMaphieu = ct.sMaphieu
 Join tblSach s On pm.sMasach = s.sMasach
 Join tblTheloai tl On tl.sMatheloai = s.sMatheloai
Group by s.sMatheloai, sTentheloai
GO
/****** Object:  Table [dbo].[tblPhieutra]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieutra](
	[sMaphieu] [varchar](10) NOT NULL,
	[sMasach] [varchar](10) NOT NULL,
	[iSoluongmuon] [int] NULL,
	[dNgayhentra] [date] NULL,
	[dNgaytra] [date] NOT NULL,
	[sTinhtrang] [nvarchar](20) NULL,
	[sGhichu] [nvarchar](50) NULL,
	[isDeleted] [bit] NULL,
 CONSTRAINT [PK__tblPhieu__52AA3D4616576E73] PRIMARY KEY CLUSTERED 
(
	[sMaphieu] ASC,
	[sMasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_DSPT]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_DSPT]
As Select pt.sMaphieu as [Mã phiếu], sMadocgia as [Mã độc giả], pt.sMasach as [Mã sách], iSoluongmuon as [Sl mượn],
dNgayhentra as [Ngày hẹn trả], dNgaytra as [Ngày trả], sTinhtrang as [Tình trạng], sGhichu as [Ghi chú]
From tblPhieutra pt 
Join tblPhieumuon pm On pt.sMaphieu = pm.sMaphieu
Where isDeleted = 0;
GO
/****** Object:  View [dbo].[v_DSDG]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSDG]
AS
SELECT sMadocgia AS [Mã độc giả], sTendocgia AS [Tên độc giả], dNgaysinh AS [Ngày sinh], sGioitinh AS [Giới tính], sEmail AS Email, sDiachi AS [Địa chỉ], sSdt AS [Số điện thoại], sMaloaidocgia AS [Mã loại độc giả], dNgaylapthe AS [Ngày lập thẻ], dNgayhethan AS [Ngày hết hạn]
FROM   dbo.tblDocGia
WHERE (isDeleted = 0)
GO
/****** Object:  View [dbo].[v_DSS1]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSS1]
AS
SELECT s.sMasach AS [Mã sách], s.sTensach AS [Tên sách], tl.sTentheloai AS [Thể loại], s.sNhaxuatban AS NXB, s.fDongia AS [Đơn giá], s.sTinhtrang AS [Tình trạng]
FROM   dbo.tblSach AS s INNER JOIN
           dbo.tblTheloai AS tl ON s.sMatheloai = tl.sMatheloai
WHERE (s.isDeleted = 0)
GO
/****** Object:  Table [dbo].[tblLoaidocgia]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaidocgia](
	[sMaloaidocgia] [varchar](10) NOT NULL,
	[sTenloaidocgia] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[sMatk] [int] IDENTITY(1,1) NOT NULL,
	[sTentk] [varchar](10) NOT NULL,
	[sMatkhau] [varchar](8) NOT NULL,
	[sLoaitk] [nvarchar](6) NOT NULL,
	[sMadocgia] [varchar](10) NULL,
	[isDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[sMatk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sTentk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCTmuontra] ADD  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[tblDocGia] ADD  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[tblPhieutra] ADD  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[tblSach] ADD  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[tblTaiKhoan] ADD  DEFAULT ((0)) FOR [isDeleted]
GO
ALTER TABLE [dbo].[tblCTmuontra]  WITH CHECK ADD FOREIGN KEY([sMaphieu])
REFERENCES [dbo].[tblPhieumuon] ([sMaphieu])
GO
ALTER TABLE [dbo].[tblCTmuontra]  WITH CHECK ADD FOREIGN KEY([sMasach])
REFERENCES [dbo].[tblSach] ([sMasach])
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK__tblDocGia__sMalo__48CFD27E] FOREIGN KEY([sMaloaidocgia])
REFERENCES [dbo].[tblLoaidocgia] ([sMaloaidocgia])
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK__tblDocGia__sMalo__48CFD27E]
GO
ALTER TABLE [dbo].[tblPhieumuon]  WITH CHECK ADD  CONSTRAINT [FK__tblPhieum__sMado__0C50D423] FOREIGN KEY([sMadocgia])
REFERENCES [dbo].[tblDocGia] ([sMadocgia])
GO
ALTER TABLE [dbo].[tblPhieumuon] CHECK CONSTRAINT [FK__tblPhieum__sMado__0C50D423]
GO
ALTER TABLE [dbo].[tblPhieutra]  WITH CHECK ADD  CONSTRAINT [FK_pmuon] FOREIGN KEY([sMasach])
REFERENCES [dbo].[tblSach] ([sMasach])
GO
ALTER TABLE [dbo].[tblPhieutra] CHECK CONSTRAINT [FK_pmuon]
GO
ALTER TABLE [dbo].[tblPhieutra]  WITH CHECK ADD  CONSTRAINT [FK_ptra] FOREIGN KEY([sMaphieu])
REFERENCES [dbo].[tblPhieumuon] ([sMaphieu])
GO
ALTER TABLE [dbo].[tblPhieutra] CHECK CONSTRAINT [FK_ptra]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [Fk_sach_theloai] FOREIGN KEY([sMatheloai])
REFERENCES [dbo].[tblTheloai] ([sMatheloai])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [Fk_sach_theloai]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD FOREIGN KEY([sMadocgia])
REFERENCES [dbo].[tblDocGia] ([sMadocgia])
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [CK__tblDocGia__sGioi__47DBAE45] CHECK  (([sGioitinh]=N'Nữ' OR [sGioitinh]='Nam'))
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [CK__tblDocGia__sGioi__47DBAE45]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD CHECK  (([sLoaitk]='Docgia' OR [sLoaitk]='Admin'))
GO
/****** Object:  StoredProcedure [dbo].[prThemCTmuontra]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   Create proc [dbo].[prThemCTmuontra]
   (@maphieu varchar(10),
    @masach varchar(10),
	@ntra date,
	@sl int,
	@ttrang nvarchar(50),
	@gchu nvarchar(100))
	As
	Begin
			Insert into tblCTmuontra
			Values (@maphieu,@masach,@ntra,@sl,@ttrang,@gchu)
	End
GO
/****** Object:  StoredProcedure [dbo].[prThemdocgia]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    Create Proc [dbo].[prThemdocgia]
 (@ma varchar(10),
  @ten nvarchar(30),
  @nsinh date,
  @gt nvarchar(5),
  @diachi nvarchar(30),
  @sdt varchar(10),
  @loaidg varchar(10))
  As
  begin
		Insert into tblDocGia
		Values(@ma,@ten,@nsinh,@gt,@diachi,@sdt,@loaidg)
  end
GO
/****** Object:  StoredProcedure [dbo].[prThemloaidg]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   Create Proc [dbo].[prThemloaidg]
 (@ma varchar(10),
  @ten nvarchar(30))
  As
  begin
		Insert into tblLoaidocgia
		Values(@ma,@ten)
  end
GO
/****** Object:  StoredProcedure [dbo].[prThemphieumuon]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create Proc [dbo].[prThemphieumuon]
  (@maphieu varchar(10),
   @madg varchar(10),
   @ntra date)
   As
   Begin
		Insert into tblPhieumuon
		Values (@maphieu,@madg,@ntra)
   End
GO
/****** Object:  StoredProcedure [dbo].[prThemsach]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE Proc [dbo].[prThemsach]
 (@ma varchar(10),
  @ten nvarchar(30),
  @matl varchar(10),
  @nxb nvarchar(50),
  @ngaynhap datetime,
  @dg float,
  @sl int,
  @tt nvarchar(5))
  As
  begin
		Insert into tblSach
		Values(@ma,@ten,@matl,@nxb,@ngaynhap,@dg,@sl,@tt)
  end
GO
/****** Object:  StoredProcedure [dbo].[prThemtk]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create Proc [dbo].[prThemtk]
 (@ma varchar(10),
  @ten nvarchar(30))
  As
  begin
		Insert into tblTaikhoan
		Values(@ma,@ten)
  end
GO
/****** Object:  StoredProcedure [dbo].[prThemtheloai]    Script Date: 2/8/2025 1:58:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create Proc [dbo].[prThemtheloai]
 (@ma varchar(10),
  @ten nvarchar(30))
  As
  begin
		Insert into tblTheloai
		Values(@ma,@ten)
  end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblDocGia"
            Begin Extent = 
               Top = 12
               Left = 76
               Bottom = 259
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSDG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSDG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ct"
            Begin Extent = 
               Top = 12
               Left = 76
               Bottom = 259
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "pm"
            Begin Extent = 
               Top = 264
               Left = 76
               Bottom = 477
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 480
               Left = 76
               Bottom = 727
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "dg"
            Begin Extent = 
               Top = 732
               Left = 76
               Bottom = 979
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSPM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSPM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblSach"
            Begin Extent = 
               Top = 12
               Left = 76
               Bottom = 259
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "s"
            Begin Extent = 
               Top = 12
               Left = 76
               Bottom = 259
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tl"
            Begin Extent = 
               Top = 264
               Left = 76
               Bottom = 443
               Right = 351
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSS1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_DSS1'
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
