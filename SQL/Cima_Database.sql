USE [master]
GO
/****** Object:  Database [Cima_DB]    Script Date: 12/23/2020 2:51:52 PM ******/
CREATE DATABASE Cima_DB
USE Cima_DB
GO
/****** Object:  Table [dbo].[ChiTietDH]    Script Date: 12/23/2020 2:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDH](
	[MaDH] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDH] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 12/23/2020 2:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDM] [nchar](10) NOT NULL,
	[TenDM] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 12/23/2020 2:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [nchar](10) NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[NguoiDat] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[HinhThucTT] [nvarchar](50) NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/23/2020 2:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[AnhSP] [text] NOT NULL,
	[ThongSo] [text] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaDM] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/23/2020 2:51:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nchar](20) NOT NULL,
	[MatKhau] [nchar](20) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[Level] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDH] ([MaDH], [MaSP], [SoLuong]) VALUES (N'DH01      ', N'SP02      ', 1)
INSERT [dbo].[ChiTietDH] ([MaDH], [MaSP], [SoLuong]) VALUES (N'DH02      ', N'SP02      ', 3)
INSERT [dbo].[ChiTietDH] ([MaDH], [MaSP], [SoLuong]) VALUES (N'DH02      ', N'SP03      ', 1)
GO
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM02      ', N'MacBook')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM03      ', N'iMac')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM05      ', N'Apple TV')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM06      ', N'Iphone')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM07      ', N'Ipad')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM08      ', N'Apple Watch')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM]) VALUES (N'DM09      ', N'AirPods')
GO
INSERT [dbo].[DonHang] ([MaDH], [NgayDat], [NguoiDat], [DiaChi], [HinhThucTT], [TongTien]) VALUES (N'DH01      ', CAST(N'2020-12-12T00:00:00.000' AS DateTime), N'Xuân Sơn', N'Lai Châu', N'Trực tiếp', 12000000)
INSERT [dbo].[DonHang] ([MaDH], [NgayDat], [NguoiDat], [DiaChi], [HinhThucTT], [TongTien]) VALUES (N'DH02      ', CAST(N'2020-12-12T00:00:00.000' AS DateTime), N'Khương Tuyế', N'Lào Cai', N'Online', 13900000)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP010     ', N'Iphone X Plus', N'iphone-x-plus-400x400.jpg                         ', N'256GB', N'Còn hàng', 16900000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP02      ', N'Iphone 11', N'iphone-11-128gb-green-400x400.jpg                 ', N'128GB', N'Còn hàng', 11900000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP020     ', N'Apple Watch S6 LTE', N'AppleWatch-SE-Gold.jpg                            ', N'32GB', N'Còn hàng', 15800000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP021     ', N'Apple Watch S5 LTE', N'AppleWatch-SE-SpaceGray.jpg                       ', N'32GB', N'Còn hàng', 14900000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP022     ', N'Apple Watch SE', N'sewhite.jpg                                       ', N'32GB', N'Còn hàng', 18900000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP023     ', N'Apple Watch S6', N'AppleWatch-Series6-Gold.jpg                       ', N'32GB', N'Còn hàng', 16800000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP024     ', N'Apple Watch 5G', N'AppleWatch-Series6-Blue.jpg                       ', N'32GB', N'Còn hàng', 21900000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP025     ', N'Apple Watch S5', N'as_5_2.jpg                                        ', N'32GB', N'Còn hàng', 9800000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP027     ', N'Apple Watch SE Plus', N'AppleWatch-Series6-Silver.jpg                     ', N'32GB', N'Còn hàng', 15500000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP028     ', N'Apple Watch SE 5G', N'AppleWatch-SE-SpaceGray.jpg                       ', N'32GB', N'Còn hàng', 19800000, N'DM08      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP03      ', N'Iphone XR', N'iphone-xr-white-400x400.jpg                       ', N'256GB', N'Còn hàng', 13500000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP030     ', N'MacBook Air 2020', N's6red.jpg                                         ', N'16GB, DDR4 (1 khe), 2666 MHz', N'Còn hàng', 52800000, N'DM02      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP031     ', N'MacBook Air 2020 Pro', N's52.jpg                                           ', N'16GB, DDR4 (1 khe), 2666 MHz', N'Còn hàng', 48900000, N'DM02      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP034     ', N'MacBook Air 2019', N'2020.jpg                                          ', N'32GB, DDR4 (1 khe), 2666 MHz', N'Còn hàng', 56900000, N'DM02      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP04      ', N'Iphone XS Max', N'iphone-xs-max-256gb-white-400x400.jpg             ', N'256GB', N'Còn hàng', 14700000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP05      ', N'Iphone X', N'iphone-x-64gb-hh-400x400.jpg                      ', N'256GB', N'Còn hàng', 12900000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP06      ', N'Iphone 12', N'iphone-12-max-400x400.jpg                         ', N'128GB', N'Còn hàng', 19800000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP07      ', N'Iphone SE', N'iphone-se-2021-600-400x400.jpg                    ', N'256GB', N'Còn hàng', 16900000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'SP09      ', N'Iphone 11 Pro', N'iphone-11-red-400x400.jpg                         ', N'256GB', N'Còn hàng', 14500000, N'DM06      ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [AnhSP], [ThongSo], [TrangThai], [DonGia], [MaDM]) VALUES (N'sp35      ', N'MacBook Air 2019 Pro', N's52.jpg                                           ', N'16GB, DDR4 (1 khe), 2666 MHz', N'Còn hàng', 36900000, N'DM02      ')
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [Email], [Level]) VALUES (N'admin               ', N'admin               ', N'admin@gmail.com                                   ', 1)
GO

