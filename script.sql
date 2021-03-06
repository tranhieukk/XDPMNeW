USE [QLDiemSV]
GO
/****** Object:  UserDefinedFunction [dbo].[DiemTBC]    Script Date: 1/9/18 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[DiemTBC] 
(

@MaSV varchar(10),
@MaHK varchar(10)
	
)
RETURNS float
AS
BEGIN
declare @dvhp  as float
declare @dmh as float
declare @maMH as varchar(10)
declare @TongKet as float
declare @Sum as float
declare @TongDVHP as float
declare @MonHoc cursor
declare @DTX as float
declare @D15P as float
declare @DGK as float
declare @DCK as float
declare @DTL as float
declare @HDTX  as float
declare @HD15P as float
declare @HDGK as  float
declare @HDCK as float
set @Sum =0
set @TongKet=0
set @TongDVHP =0
set @HDTX =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HTX')
set @HD15P =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'H15')
set @HDGK =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HGK')
set @HDCK =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HCK')
set @MonHoc = Cursor for 
select MaMonHoc from BangDiem where MaHocKy = @MaHK and MaSinhVien = @MaSV
open @MonHoc
Fetch next from @MonHoc into @maMH
while @@FETCH_STATUS=0
begin
declare @tam as float
set @tam = 0
select @dvhp =MonHoc.SoHocPhan from MonHoc where MaMonHoc = @maMH
Select @TongKet =dbo.DiemTongKet(DiemThuongXuyen, Diem15p,DiemGiuaKy,DiemThiLan1,DiemThiLan2) from BangDiem where MaMonHoc = @maMH and MaSinhVien = @MaSV
if(@TongKet is not null)
set @tam = @TongKet*@dvhp
set @TongDVHP +=@dvhp



fetch next from @MonHoc into @maMH

set @Sum +=@tam
end
close @MonHoc
Deallocate @MonHoc

return @Sum/@TongDVHP
END
GO
/****** Object:  UserDefinedFunction [dbo].[DiemTongKet]    Script Date: 1/9/18 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[DiemTongKet] 
(
@DTX float,
@D15P float,
@DGK float,
@DCK float,
@DTL float
	
)
RETURNS float
AS
BEGIN
declare @HDTX  as float
declare @HD15P as float
declare @HDGK as  float
declare @HDCK as float
declare @TongKet as float

set @HDTX =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HTX')
set @HD15P =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'H15')
set @HDGK =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HGK')
set @HDCK =(select ThamSo.GiaTri from ThamSo where MaThamSo = 'HCK')
set @TongKet =(@DTX*@HDTX+@D15P*@HD15P+@DGK*@HDGK+@DCK*@HDCK)/100
return @TongKet

END
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 1/9/18 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[Stt] [int] IDENTITY(1,1) NOT NULL,
	[MaSinhVien] [varchar](10) NOT NULL,
	[MaMonHoc] [varchar](10) NOT NULL,
	[MaHocKy] [varchar](10) NOT NULL,
	[DiemThuongXuyen] [float] NULL,
	[Diem15p] [float] NULL,
	[DiemGiuaKy] [float] NULL,
	[DiemThiLan1] [float] NULL,
	[DiemThiLan2] [float] NULL,
	[addTX_ed_at] [datetime] NULL,
	[add15p_ed_at] [datetime] NULL,
	[addGiuaKy_ed_at] [datetime] NULL,
	[addThiLan1_ed_at] [datetime] NULL,
	[addThiLan2_ed_at] [datetime] NULL,
	[updateTX_ed_at] [datetime] NULL,
	[update15p_ed_at] [datetime] NULL,
	[updateGiuaKy_ed_at] [datetime] NULL,
	[updateThiLan1_ed_at] [datetime] NULL,
	[updateThiLan2_ed_at] [datetime] NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[Stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangDiemRenLuyen]    Script Date: 1/9/18 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiemRenLuyen](
	[Stt] [int] IDENTITY(1,1) NOT NULL,
	[MaSinhVien] [varchar](10) NOT NULL,
	[MaHocKy] [varchar](10) NOT NULL,
	[MaTieuChi] [char](10) NULL,
	[TuCham] [int] NULL,
	[LopTruong] [int] NULL,
	[GVCN] [int] NULL,
	[Khoa] [int] NULL,
	[addTC_at] [datetime] NULL,
	[addLT_at] [datetime] NULL,
	[addGV_at] [datetime] NULL,
	[addKhoa_at] [datetime] NULL,
	[updateTC_at] [datetime] NULL,
	[updateLT_at] [datetime] NULL,
	[updateGV_at] [datetime] NULL,
	[updateKhoa_at] [datetime] NULL,
 CONSTRAINT [PK_BangDiemRenLuyen] PRIMARY KEY CLUSTERED 
(
	[Stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangQuyen]    Script Date: 1/9/18 1:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangQuyen](
	[MaQuyen] [char](10) NOT NULL,
	[NoiDungQuyen] [nvarchar](100) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietQuyenHan]    Script Date: 1/9/18 1:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietQuyenHan](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaQuyen] [char](10) NULL,
	[tenHoatDong] [nvarchar](20) NULL,
	[Code_hoatDong] [varchar](50) NULL,
 CONSTRAINT [PK__ChiTietQ__CDF0A11485D6E5C9] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeDaoTao]    Script Date: 1/9/18 1:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeDaoTao](
	[MaHe] [varchar](10) NOT NULL,
	[TenHe] [nvarchar](50) NOT NULL,
	[ThoiGianHoc] [float] NULL,
 CONSTRAINT [PK_HeDaoTao] PRIMARY KEY CLUSTERED 
(
	[MaHe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 1/9/18 1:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHocKy] [varchar](10) NOT NULL,
	[TenHocKy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/9/18 1:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[Tenkhoa] [nvarchar](50) NOT NULL,
	[logo] [varchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [varchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MaKhoaHoc] [varchar](10) NOT NULL,
	[MaHeDaoTao] [varchar](10) NOT NULL,
	[MaNganh] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NOT NULL,
	[SoHocPhan] [int] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhDaoTao]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhDaoTao](
	[MaNganh] [varchar](10) NOT NULL,
	[TenNganh] [nvarchar](50) NOT NULL,
	[MaKhoa] [varchar](10) NULL,
 CONSTRAINT [PK_NganhDaoTao] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenHan]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenHan](
	[TaiKhoan] [varchar](30) NOT NULL,
	[MaQuyen] [char](10) NOT NULL,
	[ChoPhep] [bit] NOT NULL,
 CONSTRAINT [PK_QuyenHan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC,
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](10) NOT NULL,
	[Họ] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[QueQuan] [nvarchar](200) NULL,
	[Anh] [image] NULL,
	[MaLop] [varchar](10) NOT NULL,
	[DiaChi] [nvarchar](500) NOT NULL,
	[ChinhSachUuTien] [bit] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 1/9/18 1:06:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[MaThamSo] [varchar](10) NOT NULL,
	[GiaTri] [float] NULL,
	[GhiChu] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinDangNhap]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDangNhap](
	[username] [varchar](30) NOT NULL,
	[displayName] [nvarchar](50) NULL,
	[password] [varchar](30) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_ThongTinDangNhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TieuChiRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TieuChiRenLuyen](
	[MaTieuChi] [char](10) NOT NULL,
	[NoiDungTieuChi] [nvarchar](200) NULL,
	[MucDiem] [int] NULL,
 CONSTRAINT [PK_TieuChiRenLuyen] PRIMARY KEY CLUSTERED 
(
	[MaTieuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ThongTinDangNhap] ADD  CONSTRAINT [DF_ThongTinDangNhap_TrangThai]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocKy] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKy] ([MaHocKy])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocKy]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_SinhVien]
GO
ALTER TABLE [dbo].[BangDiemRenLuyen]  WITH CHECK ADD  CONSTRAINT [FK_BangDiemRenLuyen_HocKy] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKy] ([MaHocKy])
GO
ALTER TABLE [dbo].[BangDiemRenLuyen] CHECK CONSTRAINT [FK_BangDiemRenLuyen_HocKy]
GO
ALTER TABLE [dbo].[BangDiemRenLuyen]  WITH CHECK ADD  CONSTRAINT [FK_BangDiemRenLuyen_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BangDiemRenLuyen] CHECK CONSTRAINT [FK_BangDiemRenLuyen_SinhVien]
GO
ALTER TABLE [dbo].[BangDiemRenLuyen]  WITH CHECK ADD  CONSTRAINT [FK_BangDiemRenLuyen_TieuChiRenLuyen] FOREIGN KEY([MaTieuChi])
REFERENCES [dbo].[TieuChiRenLuyen] ([MaTieuChi])
GO
ALTER TABLE [dbo].[BangDiemRenLuyen] CHECK CONSTRAINT [FK_BangDiemRenLuyen_TieuChiRenLuyen]
GO
ALTER TABLE [dbo].[ChiTietQuyenHan]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietQu__MaQuy__6166761E] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[BangQuyen] ([MaQuyen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietQuyenHan] CHECK CONSTRAINT [FK__ChiTietQu__MaQuy__6166761E]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_HeDaoTao] FOREIGN KEY([MaHeDaoTao])
REFERENCES [dbo].[HeDaoTao] ([MaHe])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_HeDaoTao]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoaHoc] FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoaHoc]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_NganhDaoTao] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NganhDaoTao] ([MaNganh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_NganhDaoTao]
GO
ALTER TABLE [dbo].[NganhDaoTao]  WITH CHECK ADD  CONSTRAINT [FK_NganhDaoTao] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[NganhDaoTao] CHECK CONSTRAINT [FK_NganhDaoTao]
GO
ALTER TABLE [dbo].[QuyenHan]  WITH CHECK ADD  CONSTRAINT [FK_QuyenHan_BangQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[BangQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[QuyenHan] CHECK CONSTRAINT [FK_QuyenHan_BangQuyen]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
/****** Object:  StoredProcedure [dbo].[USP_addChuyenNganh]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addChuyenNganh]
 @MaNganh varchar(10) ,
 @TenNganh nvarchar(50),
 @MaKhoa varchar(10)
as
begin
insert into NganhDaoTao values(@MaNganh,@TenNganh,@MaKhoa)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addDiem]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_addDiem]
@maSinhVien varchar(10),
@maMonHoc varchar(10),
@maHocKy varchar(10),
@diemTX float,
@diem15p float,
@diemGK float,
@diemCK1 float,
@diemCK2 float
as
begin
declare @check as int
declare @add as float
if(@diemTX is not null and  @diemTX <>'')
	begin
		select @check = count(Stt) from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
		if(@check>0)
		begin
			select @add =DiemThuongXuyen  from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
			if(@add is not null and  @add <>'')
				begin
				if @add <>@diemTX
				update BangDiem set DiemThuongXuyen = @diemTX ,updateTX_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
			else
				begin
				update BangDiem set DiemThuongXuyen = @diemTX ,addTX_ed_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
		end
		else
		begin
			insert into BangDiem (MaSinhVien,MaMonHoc,MaHocKy,DiemThuongXuyen,addTX_ed_at) values(@maSinhVien,@maMonHoc, @maHocKy,@diemTX,Getdate())
		end
	end

	if(@diem15p is not null and  @diem15p <>'')
	begin
		select @check = count(Stt) from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
		if(@check>0)
		begin
			select @add =Diem15p  from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
			if(@add is not null and  @add <>'')
				begin
				if @add <> @diem15p
				update BangDiem set Diem15p = @diem15p ,update15p_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
			else
				begin
				update BangDiem set Diem15p = @diem15p ,add15p_ed_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
		end
		else
		begin
			insert into BangDiem (MaSinhVien,MaMonHoc,MaHocKy,Diem15p,add15p_ed_at) values(@maSinhVien,@maMonHoc, @maHocKy,@diem15p,Getdate())
		end
	end

	if(@diemGK is not null and  @diemGK <>'')
	begin
		select @check = count(Stt) from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
		if(@check>0)
		begin
			select @add =DiemGiuaKy  from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
			if(@add is not null and  @add <>'')
				begin
				if @add <> @diemGK
				update BangDiem set DiemGiuaKy = @diemGK ,updateGiuaKy_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
			else
				begin
				update BangDiem set DiemGiuaKy = @diemGK ,addGiuaKy_ed_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
		end
		else
		begin
			insert into BangDiem (MaSinhVien,MaMonHoc,MaHocKy,DiemGiuaKy,addGiuaKy_ed_at) values(@maSinhVien,@maMonHoc, @maHocKy,@diemGK,Getdate())
		end
	end


	if(@diemCK1 is not null and  @diemCK1 <>'')
	begin
		select @check = count(Stt) from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
		if(@check>0)
		begin
			select @add =DiemThiLan1  from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
			if(@add is not  null and  @add <>'')
				begin
				if @add <> @diemCK1
				update BangDiem set DiemThiLan1 = @diemCK1 ,updateThiLan1_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
			else
				begin
				update BangDiem set DiemThiLan1 = @diemCK1 ,addThiLan1_ed_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
		end
		else
		begin
			insert into BangDiem (MaSinhVien,MaMonHoc,MaHocKy,DiemThiLan1,addThiLan1_ed_at) values(@maSinhVien,@maMonHoc, @maHocKy,@diemCK1,Getdate())
		end
	end


	if(@diemCK2 is not null and  @diemCK2 <>'')
	begin
		select @check = count(Stt) from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
		if(@check>0)
		begin
			select @add =DiemThiLan2  from BangDiem where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
			if(@add is not null and  @add <>'')
				begin
				if @add <> @diemCK2
				update BangDiem set DiemThiLan2 = @diemCK2 ,updateThiLan2_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
			else
				begin
				update BangDiem set DiemThiLan2 = @diemCK2 ,addThiLan2_ed_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
				end
		end
		else
		begin
			insert into BangDiem (MaSinhVien,MaMonHoc,MaHocKy,DiemThiLan2,addThiLan2_ed_at) values(@maSinhVien,@maMonHoc, @maHocKy,@diemCK2,Getdate())
		end
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addDiemRenLuyen]
@maSinhVien varchar(10),
@maHocKy varchar(10),
@maTieuChi char(10),
@diemTuCham int,
@diemLTCham int,
@diemGVCNCham int,
@diemKhoaCham int

as
begin
declare @check as int
declare @add as int
if(@diemTuCham is not null and  @diemTuCham <>'')
	begin
		select @check = count(Stt) from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
		if(@check>0)
		begin
			select @add =TuCham  from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
			if(@add is not null and  @add <>'')
				begin
				update BangDiemRenLuyen set TuCham = @diemTuCham ,updateTC_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
			else
				begin
				update BangDiemRenLuyen set TuCham = @diemTuCham ,addTC_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
		end
		else
		begin
			insert into BangDiemRenLuyen (MaSinhVien,MaTieuChi,MaHocKy,TuCham,addTC_at) values(@maSinhVien,@MaTieuChi, @maHocKy,@diemTuCham,Getdate())
		end
	end

	if(@diemLTCham is not null and  @diemLTCham <>'')
	begin
		select @check = count(Stt) from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
		if(@check>0)
		begin
			select @add =LopTruong  from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
			if(@add is not null and  @add <>'')
				begin
				update BangDiemRenLuyen set LopTruong = @diemLTCham ,updateLT_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
			else
				begin
				update BangDiemRenLuyen set LopTruong = @diemLTCham ,addLT_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
		end
		else
		begin
			insert into BangDiemRenLuyen (MaSinhVien,MaTieuChi,MaHocKy,LopTruong,addLT_at) values(@maSinhVien,@MaTieuChi, @maHocKy,@diemLTCham,Getdate())
		end
	end

	if(@diemGVCNCham is not null and  @diemGVCNCham <>'')
	begin
		select @check = count(Stt) from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
		if(@check>0)
		begin
			select @add =GVCN  from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
			if(@add is not null and  @add <>'')
				begin
				update BangDiemRenLuyen set GVCN = @diemGVCNCham ,updateGV_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
			else
				begin
				update BangDiemRenLuyen set GVCN = @diemGVCNCham ,addGV_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
		end
		else
		begin
			insert into BangDiemRenLuyen (MaSinhVien,MaTieuChi,MaHocKy,GVCN,addGV_at) values(@maSinhVien,@MaTieuChi, @maHocKy,@diemGVCNCham,Getdate())
		end
	end


	if(@diemKhoaCham is not null and  @diemKhoaCham <>'')
	begin
		select @check = count(Stt) from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
		if(@check>0)
		begin
			select @add =Khoa  from BangDiemRenLuyen where MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
			if(@add is not  null and  @add <>'')
				begin
				update BangDiemRenLuyen set Khoa = @diemKhoaCham ,updateKhoa_at = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
			else
				begin
				update BangDiemRenLuyen set Khoa = @diemKhoaCham ,addKhoa_at  = Getdate() where  MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @MaTieuChi
				end
		end
		else
		begin
			insert into BangDiemRenLuyen (MaSinhVien,MaTieuChi,MaHocKy,Khoa,addKhoa_at) values(@maSinhVien,@MaTieuChi, @maHocKy,@diemKhoaCham,Getdate())
		end
	end


end
GO
/****** Object:  StoredProcedure [dbo].[USP_addHeDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addHeDaoTao]
 

 @maHeDT varChar(10),
@tenHDT nvarchar(50)
as
begin
declare @dem int
select @dem = count(MaHe) from HeDaoTao where MaHe =  @maHeDT
if(@dem <= 0)
	begin
	insert into HeDaoTao values( @maHeDT,@tenHDT,'')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addHocKy]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addHocKy]
@maHocKy varChar(10),
@tenHocky nvarchar(50)
as
begin
declare @dem int
select @dem = count(MaHocKy) from HocKy where MaHocKy = @maHocKy
if(@dem <= 0)
	begin
	insert into HocKy values(@maHocKy,@tenHocky)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addKhoa]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_addKhoa]
@maKhoa nvarChar(10),
@tenKhoa nvarchar(50)
as
begin
declare @dem int
select @dem = count(MaKhoa) from Khoa where MaKhoa = @maKhoa
if(@dem <= 0)
	begin
	insert into Khoa values(@maKhoa,@tenKhoa,'logo.jpg')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addLogo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addLogo] 
@maKhoa varchar(10),
@img varbinary(MAX) 
as
begin
Update  Khoa Set logo = @img  where MaKhoa = @maKhoa 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_addLop]
@maLop varchar(10),
 @tenLop nvarchar(50), 
 @makhoaHoc varchar(10),
 @heDaoTao varchar(10),
 @nganhHoc varchar(10) 

as
begin
insert into Lop values(@maLop,@tenLop,@makhoaHoc, @heDaoTao,@nganhHoc)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addMonHoc]
 @maMonHoc varchar(10) ,
  @tenMonHoc nvarchar(50), 
  @soDVHT int
as
begin
insert into  MonHoc values(@maMonHoc , @tenMonHoc , @soDVHT )

end
GO
/****** Object:  StoredProcedure [dbo].[USP_addQuyenHan]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_addQuyenHan] 
@maQH char(10) , 
@noiDungQH nvarchar(100),
@trangThai bit

as
begin
insert into BangQuyen values(@maQH , @noiDungQH , @trangThai)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addSinhVien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addSinhVien]
@MaSinhVien varchar(10),
@Ho nvarchar(50),
@Ten nvarchar(50),
@NgaySinh date,
@GioiTinh bit,
@anh image,
@malop varchar(10),
@diaChi nvarchar(500),
@chinhSach bit
as
begin
insert into SinhVien 
values( @MaSinhVien,
		@Ho,
		@Ten ,
		@NgaySinh,
		@GioiTinh ,
		@anh,
		@malop ,
		@diaChi ,
		@chinhSach)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_addThamSo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_addThamSo] 
@maThamSo varchar(10),
@giaTri float, 
@ghiChu nvarchar(300)
as
begin

insert into ThamSo values( @maThamSo ,@giaTri , @ghiChu )

end
GO
/****** Object:  StoredProcedure [dbo].[USP_addTieuChiRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_addTieuChiRenLuyen]  
@maTC Char(10),
 @noiDung nvarchar(200),
  @diem int
as
begin
declare @dem int
select @dem = count(@maTC) from TieuChiRenLuyen where MaTieuChi = @maTC
if(@dem = 0)
	begin
	insert into TieuChiRenLuyen values(@maTC,@noiDung,@dem)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_CheckLop]
@maLop varchar(10)
as
begin
select  count(MaLop) as [SL] from Lop where MaLop = @maLop
end

GO
/****** Object:  StoredProcedure [dbo].[USP_CheckMaHocKy]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_CheckMaHocKy]
@maHocKy varchar(10)
as
select count( MaHocKy) as soLuong from HocKy where MaHocKy = @maHocKy
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckMaSinhVien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_CheckMaSinhVien]
@msv varchar(10)
as
select count( MaSinhVien) as soLuong from SinhVien where MaSinhVien = @msv and trangthai >=1
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckMaTieuChi]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_CheckMaTieuChi] 
@mtc varchar(10)
as
select count( MaTieuChi) as soLuong from TieuChiRenLuyen where MaTieuChi = @mtc
GO
/****** Object:  StoredProcedure [dbo].[USP_checkMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_checkMonHoc]
@maMonHoc varchar(10)
as
begin
select  count(MaMonHoc) as [LS] from MonHoc where MaMonHoc = @maMonHoc
end

GO
/****** Object:  StoredProcedure [dbo].[USP_deleteChuyenNganh]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_deleteChuyenNganh]
 @MaNganh varchar(10) 
as
begin
delete from NganhDaoTao where MaNganh = @MaNganh;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_deleteDiemRenLuyen] 
@maSinhVien varchar(10),
@maHocKy varchar(10),
@maTieuChi char(10)
as
delete 
 from
 BangDiemRenLuyen 
 Where
 MaSinhVien= @maSinhVien and MaHocKy = @maHocKy and MaTieuChi = @maTieuChi
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteHeDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[USP_deleteHeDaoTao]
@maHeDT nvarchar(10)
as
begin
delete   from HeDaoTao where MaHe = @maHeDT
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteKhoa]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[USP_deleteKhoa]
@makhoa nvarchar(10)
as
begin
delete   from Khoa where MaKhoa = @makhoa
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_deleteMonHoc]
 @maMonHoc varchar(10) 
as
begin
delete from MonHoc where MaMonHoc= @maMonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteQuyenHan]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_deleteQuyenHan] 
@maQH char(10)
as
delete from BangQuyen where MaQuyen = @maQH
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteSinhVien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_deleteSinhVien] 
@MaSinhVien varChar(10)
as
begin
delete from SinhVien where MaSinhVien = @MaSinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteThamSo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_deleteThamSo]
 @maThamSo  varchar(10)
as
begin
delete from ThamSo where MaThamSo = @maThamSo
end
GO
/****** Object:  StoredProcedure [dbo].[USP_deleteTieuChiRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_deleteTieuChiRenLuyen]

@maTC Char(10)

as
begin

delete from TieuChiRenLuyen where MaTieuChi = @maTC


end
GO
/****** Object:  StoredProcedure [dbo].[USP_deletetLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_deletetLop] 
@malopOld varChar(10)

as
begin
delete from Lop where MaLop = @malopOld
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DemSoLuongTieuChiSV]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_DemSoLuongTieuChiSV]
 @maSinhVien varchar(10),
 @maHocKy varchar(10)

as
select  count(MaTieuChi) as SoLuong from BangDiemRenLuyen where MaSinhVien = @maSinhVien and MaHocKy = @maHocKy
GO
/****** Object:  StoredProcedure [dbo].[USP_editChuyenNganh]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editChuyenNganh]
@maNganhHientai varchar(10),
 @MaNganh varchar(10) ,
 @TenNganh nvarchar(50),
 @MaKhoa varchar(10)
as
begin
update NganhDaoTao set MaNganh = @MaNganh where MaNganh = @maNganhHientai
update NganhDaoTao set TenNganh = @TenNganh,MaKhoa = @MaKhoa where MaNganh = @MaNganh
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editHeDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editHeDaoTao]
@maHDTOld  nvarchar(10),
 @maHeDT nvarChar(10),
@tenHDT nvarchar(50)
as
begin
declare @demtenHeDaoTao int
declare @demMaHeDaoTao int
select @demMaHeDaoTao = count(MaHe) from HeDaoTao where MaHe =  @maHeDT
select @demtenHeDaoTao = count (MaHe) from HeDaoTao where MaHe =@tenHDT
if( @maHeDT = @maHDTOld ) set @demMaHeDaoTao = @demMaHeDaoTao -1;
if(@demtenHeDaoTao = @demtenHeDaoTao) set @demtenHeDaoTao = @demtenHeDaoTao -1;
if(@demtenHeDaoTao <=0)
if(@demMaHeDaoTao <= 0)
	begin
	
	update HeDaoTao set TenHe = @tenHDT where MaHe = @maHDTOld  
	 update HeDaoTao set MaHe =  @maHeDT where MaHe = @maHDTOld  
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editHocKy]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editHocKy]
@maHocKyold nvarchar(10),
@maHocKy nvarChar(10),
@tenHocKy nvarchar(50)
as
begin
declare @demtenHocKy int
declare @demMaHocKy int
select @demMaHocKy = count(MaHocKy) from HocKy where MaHocKy = @maHocKy
select @demtenHocKy = count (TenHocKy) from HocKy where TenHocKy =@tenHocKy
if(@maHocKy = @maHocKyold) set @demMaHocKy = @demMaHocKy -1;
if(@demtenHocKy = @demtenHocKy) set @demtenHocKy = @demtenHocKy -1;
if(@demtenHocKy <=0)
if(@demMaHocKy <= 0)
	begin
	
	update HocKy set TenHocKy = @tenHocKy where MaHocKy = @maHocKyold 
	 update HocKy set MaHocKy = @maHocKy where MaHocKy = @maHocKyold 
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editKhoa]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_editKhoa]
@makhoaold nvarchar(10),
@maKhoa nvarChar(10),
@tenKhoa nvarchar(50)
as
begin
declare @demtenkhoa int
declare @demMaKhoa int
select @demMaKhoa = count(MaKhoa) from Khoa where MaKhoa = @maKhoa
select @demtenkhoa = count (Tenkhoa) from Khoa where Tenkhoa =@tenKhoa
if(@maKhoa = @makhoaold) set @demMaKhoa = @demMaKhoa -1;
if(@demtenkhoa = @demtenkhoa) set @demtenkhoa = @demtenkhoa -1;
if(@demtenkhoa <=0)
if(@demMaKhoa <= 0)
	begin
	
	update Khoa set TenKhoa = @tenKhoa where MaKhoa = @makhoaold 
	 update Khoa set MaKhoa = @maKhoa where MaKhoa = @makhoaold 
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_editLop]
@malopOld varChar(10),
@maLop varchar(10),
 @tenLop nvarchar(50), 
 @makhoaHoc varchar(10),
 @heDaoTao varchar(10),
 @nganhHoc varchar(10) 

as
begin
declare @dem  int
 if @malopOld <> @maLop
 begin
 select @dem=count(MaLop) from Lop where MaLop = @malop
 if @dem =0
	begin
	update Lop set TenLop = @tenLop,MaKhoaHoc =@makhoaHoc,MaHeDaoTao=@heDaoTao,MaNganh = @nganhHoc where MaLop = @malopOld;
	update Lop set MaLop = @maLop where MaLop = @malopOld
	end
  end
  else
  begin
  update Lop set TenLop = @tenLop,MaKhoaHoc =@makhoaHoc,MaHeDaoTao=@heDaoTao,MaNganh = @nganhHoc where MaLop = @malopOld;
  end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editMonHoc]
@MaMonHocHientai varchar(10),
 @MaMonHoc varchar(10) ,
 @TenMonHoc nvarchar(50),
 @soDVHP int
as
begin
update MonHoc set MaMonHoc = @MaMonHoc where MaMonHoc = @MaMonHocHientai
update MonHoc set TenMonHoc = @TenMonHoc,SoHocPhan = @soDVHP where MaMonHoc = @MaMonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editQuyenHan]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_editQuyenHan] 
@maQHOld char(10), 
@MaQuyen char(10) , 
@noiDungQH nvarchar(100),
@trangThai bit

as
begin
declare @dem  int
 if @maQHOld <> @MaQuyen
 begin
 select @dem=count(MaQuyen) from BangQuyen where MaQuyen = @MaQuyen
 if @dem =0
	begin
	update BangQuyen set NoiDungQuyen =@noiDungQH ,TrangThai=@trangThai  where MaQuyen = @maQHOld;
	update BangQuyen set MaQuyen = @MaQuyen where MaQuyen = @maQHOld
	end
  end
  else
  begin
 update BangQuyen set NoiDungQuyen =@noiDungQH ,TrangThai=@trangThai  where MaQuyen = @maQHOld
  end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editSinhvien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_editSinhvien]
  @MaSinhVienOld varchar(10),
  @MaSinhVien varchar(10),
  @Ho nvarchar(50),
  @Ten nvarchar(50),
  @NgaySinh date,
  @GioiTinh bit, 
  @anh Image, 
  @malop varchar(10),
  @diaChi nvarchar(500), 
  @chinhSach bit

as
begin
declare @dem  int
 if @MaSinhVienOld <> @MaSinhVien
 begin
 select @dem=count(MaSinhVien) from SinhVien where MaSinhVien = @MaSinhVien
 if @dem =0
	begin
	update SinhVien set Họ = @Ho,Ten =@Ten,NgaySinh=@NgaySinh,GioiTinh = @GioiTinh,Anh = @anh,MaLop=@malop,DiaChi=@diaChi,ChinhSachUuTien=@chinhSach where MaSinhVien = @MaSinhVienOld;
	update SinhVien set MaSinhVien = @MaSinhVien where MaSinhVien = @maSinhVienOld
	end
  end
  else
  begin
 update SinhVien set Họ = @Ho,Ten =@Ten,NgaySinh=@NgaySinh,GioiTinh = @GioiTinh,Anh = @anh,MaLop=@malop,DiaChi=@diaChi,ChinhSachUuTien=@chinhSach where MaSinhVien = @MaSinhVienOld;
  end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editThamSo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editThamSo]
@maThamSoHientai varchar(10),
@maThamSo varchar(10),
@giaTri float, 
@ghiChu nvarchar(300)
as
begin
declare @dem as int
if @maThamSoHientai <>@maThamSo
begin 
select @dem = count(MaThamSo) from ThamSo where MaThamSo=@maThamSo
if(@dem = 0)
update ThamSo set MaThamSo = @maThamSo  where MaThamSo = @maThamSoHientai
update ThamSo set GiaTri=@giaTri ,GhiChu= @ghiChu where MaThamSo = @maThamSo
end
else
update ThamSo set GiaTri= @giaTri ,GhiChu= @ghiChu where MaThamSo = @maThamSo
end
GO
/****** Object:  StoredProcedure [dbo].[USP_editTieuChiRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_editTieuChiRenLuyen]
@maTCOld Char(10),
@maTC Char(10),
@noiDung nvarchar(200),
@diem int
as
begin
declare @dem as int

if(@maTC <>@maTCOld)
begin
select @dem = count(MaTieuChi) from TieuChiRenLuyen where MaTieuChi = @maTC
if(@dem =0)
update TieuChiRenLuyen set MaTieuChi= @maTC where MaTieuChi = @maTCOld
end

update TieuChiRenLuyen set NoiDungTieuChi = @noiDung,MucDiem = @diem where MaTieuChi = @maTC

end
GO
/****** Object:  StoredProcedure [dbo].[USP_EstablishDiemByLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_EstablishDiemByLop]
@maHKy varchar(10),
@maLop varchar(10),
@maMon varchar(10)
as
begin


declare @massv as varchar(10)
declare @getSV CurSor
set @getSV =Cursor for
select MaSinhVien from SinhVien where SinhVien.trangthai =1 and SinhVien.MaLop = @maLop
open @getSV Fetch next
from @getSV into @massv
while @@FETCH_STATUS =0
begin
insert into BangDiem(MaSinhVien,MaHocKy,MaMonHoc) values(@massv,@maHKy,@maMon)
fetch next
from @getSV into @massv
END
Close @getSV
Deallocate @getSV
end



GO
/****** Object:  StoredProcedure [dbo].[USP_FindInMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_FindInMonHoc] 
 @key1 varchar(10),
 @key2 nvarchar(50),
 @key3 varchar 
as
begin
select MaMonHoc as [Mã môn học], TenMonHoc as [Tên môn học], SoHocPhan as[Số đơn vị học trình] from MonHoc where MaMonHoc like @key1 and TenMonHoc like @key2 and SoHocPhan like @key3
end

GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
	SELECT username, displayName FROM dbo.ThongTinDangNhap WHERE username = @userName
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllData]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetAllData]
as
begin
select * from NganhDaoTao 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tham so = 0  lay toàn bô sinh vien truong
--tham so = 1 lay sinh vien lop key word la ma lop
--tham so = 2 lay sinh vien khoa keyword la ma khoa
CREATE proc  [dbo].[USP_GetAllDiemRenLuyen]
@thamSo int,
@maHocKy varchar(10),
@keyword varchar(10)
as

begin
 if(@thamSo = 0)
select SinhVien.MaSinhVien as[Mã sinh viên],
 CONCAT(Họ,' ',Ten) as [Họ và tên],
  MaTieuChi as [Mã tiêu chí],TuCham as [Tự chấm],LopTruong as[ Lớp trưởng chấm], GVCN as[Giáo viên chủ nhiệm chấm], Khoa as[Khoa chấm]
 from
 BangDiemRenLuyen 
 right join SinhVien  on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien 
 where SinhVien.trangthai >0  and BangDiemRenLuyen.MaHocKy = @maHocKy
 if(@thamSo = 1)
select SinhVien.MaSinhVien as[Mã sinh viên],
 CONCAT(Họ,' ',Ten) as [Họ và tên],
 MaTieuChi as [Mã tiêu chí],TuCham as [Tự chấm],LopTruong as[ Lớp trưởng chấm], GVCN as[Giáo viên chủ nhiệm chấm], Khoa as[Khoa chấm]
 from
 BangDiemRenLuyen 
 right join SinhVien  on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien 
 where SinhVien.MaLop = @keyword and SinhVien.trangthai >0 and BangDiemRenLuyen.MaHocKy = @maHocKy

  if(@thamSo = 2)
select SinhVien.MaSinhVien as[Mã sinh viên],
 CONCAT(Họ,' ',Ten) as [Họ và tên],
  MaTieuChi as [Mã tiêu chí],TuCham as [Tự chấm],LopTruong as[ Lớp trưởng chấm], GVCN as[Giáo viên chủ nhiệm chấm], Khoa as[Khoa chấm]
 from
 BangDiemRenLuyen 
 right join SinhVien  on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop inner join NganhDaoTao on Lop.MaNganh = NganhDaoTao.MaNganh inner join Khoa on NganhDaoTao.MaKhoa = Khoa.MaKhoa
 where Khoa.MaKhoa = @keyword and SinhVien.trangthai >0 and BangDiemRenLuyen.MaHocKy = @maHocKy

 end
 
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllHeDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getAllHeDaoTao]
as
begin
select MaHe ,TenHe from HeDaoTao 
end

GO
/****** Object:  StoredProcedure [dbo].[USP_getAllHocKy]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getAllHocKy]
as
begin
select MaHocKy as [Mã học kỳ],TenHocKy as[Tên học kỳ] from HocKy Order by MaHocKy DESC
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllKhoa]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllKhoa]
as
begin
select * from Khoa 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllKhoaHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getAllKhoaHoc]
as
begin
select MaKhoaHoc,CONCAT( N'Từ ',convert(varchar, NgayBatDau, 101) ,N' Đến ',convert(varchar, NgayKetThuc, 101)) as TenKhoaHoc from KhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getAllLop]
as
begin
select MaLop as [Mã lớp], TenLop as[Tên lớp] ,TenKhoa as[Khoa] ,TenNganh as [Chuyên ngành], TenHe as[Hệ đào tạo], CONCAT( N'Từ ',convert(varchar, NgayBatDau, 101) ,N' Đến ',convert(varchar, NgayKetThuc, 101))  as [Khóa học] from 

Lop inner join HeDaoTao on  Lop.MaHeDaoTao = HeDaoTao.MaHe inner join NganhDaoTao on  Lop.MaNganh=NganhDaoTao.MaNganh inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc inner join Khoa on NganhDaoTao.MaKhoa = Khoa.MaKhoa

end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllLopbyKhoa]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllLopbyKhoa]
@makhoa varchar(10)
as
begin
select MaLop as [Mã lớp], TenLop as[Tên lớp] from 

Lop inner join HeDaoTao on  Lop.MaHeDaoTao = HeDaoTao.MaHe inner join NganhDaoTao on  Lop.MaNganh=NganhDaoTao.MaNganh inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc inner join Khoa on NganhDaoTao.MaKhoa = Khoa.MaKhoa
where Khoa.MaKhoa = @makhoa
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllMonHoc]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllMonHoc]
as
begin
select MaMonHoc as [Mã môn học], TenMonHoc as [Tên môn học], SoHocPhan as[Số đơn vị học trình] from MonHoc 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllNganhDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetAllNganhDaoTao]
as
begin
select MaNganh as[Mã ngành],TenNganh as [Tên ngành], Tenkhoa as[Khoa] from NganhDaoTao inner join Khoa on NganhDaoTao.MaKhoa = Khoa.MaKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllQuyenHan]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllQuyenHan]
@maQH varchar(10)
as
select MaQuyen as[Mã quyền], NoiDungQuyen as [Nội dung] ,(Case TrangThai when 1 then 'Mở' when 0 then 'Khóa' end) as [Trạng thái]  from BangQuyen
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllSinhVien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getAllSinhVien]
as
begin
select MaSinhVien as[Mã Sinh viên], CONCAT(Họ,' ',Ten) as [Họ và tên], NgaySinh as [Ngày sinh], (Case GioiTinh when 1 then 'Nam' when 0 then N'Nữ' end )as[Giới tính], TenLop as[Lớp],DiaChi as [Địa Chỉ],  (case ChinhSachUuTien when 1 then 'Có' when 0 then 'Không' end )as [Chính sách ưu tiên] from SinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllThamSo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllThamSo]
as
begin

Select MaThamSo as[Mã tham số], GiaTri as[Giá trị] ,GhiChu as[Ghi chú] from ThamSo

end
GO
/****** Object:  StoredProcedure [dbo].[USP_getAllTieuChiRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getAllTieuChiRenLuyen]
as
begin
select MaTieuChi as [Mã tiêu chí] , NoiDungTieuChi as[Nội dung tiêu chí], MucDiem as[Điểm] from TieuChiRenLuyen 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getBangDiem]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_getBangDiem]
@maHKy varchar(10),
@maMon varchar(10),
@maLop varchar(10)
as
begin

select SinhVien.MaSinhVien as[Mã sinh viên],CONCAT(Họ,' ',Ten) as [Họ và tên], DiemThuongXuyen as [Thường xuyên],Diem15p as [15 phút], DiemGiuaKy as [Giữa kỳ], DiemThiLan1 as [Cuối kỳ], DiemThiLan2 as [Thi lại] from SinhVien full join BangDiem on SinhVien.MaSinhVien = BangDiem.MaSinhVien
where   SinhVien.trangthai>0 and BangDiem.MaMonHoc = @maMon and BangDiem.MaHocKy =@maHKy and MaLop = @maLop 

end
GO
/****** Object:  StoredProcedure [dbo].[USP_getCTQuyenHanByMaQuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_getCTQuyenHanByMaQuyen] 
@maQuyen char(10)

as
select * from  ChiTietQuyenHan
where MaQuyen =@maQuyen;
GO
/****** Object:  StoredProcedure [dbo].[USP_getCTQuyenHanByUsername]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_getCTQuyenHanByUsername] 
@user char(10)

as
select MaChitiet,tenHoatDong,Code_hoatDong,ChiTietQuyenHan.MaQuyen from  ChiTietQuyenHan inner join QuyenHan on ChiTietQuyenHan.MaQuyen = QuyenHan.MaQuyen
where QuyenHan.TaiKhoan=@user and ChoPhep =1;
GO
/****** Object:  StoredProcedure [dbo].[USP_getDiemByLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_getDiemByLop]
@maHKy varchar(10),
@maLop varchar(10),
@maMon varchar(10)
as
begin

select  SinhVien.MaSinhVien as[Mã sinh viên],CONCAT(Họ,' ',Ten) as [Họ và tên], DiemThuongXuyen as [Thường xuyên],Diem15p as [15 phút], DiemGiuaKy as [Giữa kỳ], DiemThiLan1 as [Cuối kỳ], DiemThiLan2 as [Thi lại] from SinhVien full join BangDiem on SinhVien.MaSinhVien = BangDiem.MaSinhVien
where SinhVien.MaLop = @maLop and SinhVien.trangthai>0 and BangDiem.MaMonHoc = @maMon and BangDiem.MaHocKy =@maHKy

end
GO
/****** Object:  StoredProcedure [dbo].[USP_getDiemBySV]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getDiemBySV]
@masv varchar(10)
as
select 
 BangDiem.MaMonHoc as[Mã môn học],TenMonHoc as [Tên môn học],MonHoc.SoHocPhan as [Số ĐVHP],dbo.DiemTongKet(DiemThuongXuyen,Diem15p,DiemGiuaKy,DiemThiLan1,DiemThiLan2) as [Điểm tổng kết] from BangDiem inner join MonHoc on BangDiem.MaMonHoc= MonHoc.MaMonHoc where MaSinhVien = @masv
GO
/****** Object:  StoredProcedure [dbo].[USP_getGiaTriThamSo]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getGiaTriThamSo]
@maThamSo varchar(10)
as
begin
select GiaTri  from ThamSo where MaThamSo = @maThamSo 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getKhoabyLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getKhoabyLop]
@maLop varchar(10)
as
begin
select Tenkhoa from Khoa inner join NganhDaoTao on Khoa.MaKhoa = NganhDaoTao.MaKhoa inner join Lop on NganhDaoTao.MaNganh = Lop.MaNganh where MaLop =@maLop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getMonHocBy]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getMonHocBy]
@maLop varchar(10)
as
select BangDiem.MaMonHoc as[Mã môn học],MonHoc.TenMonHoc as[Tên môn học],MonHoc.SoHocPhan as[ĐVHP], HocKy.TenHocKy as[Học kỳ]
 from MonHoc inner join BangDiem on MonHoc.MaMonHoc= BangDiem.MaMonHoc inner join HocKy on BangDiem.MaHocKy = HocKy.MaHocKy where MonHoc.MaMonHoc   in (
select MaMonHoc  from BangDiem where MaSinhVien in (select MaSinhVien from SinhVien where MaLop = @maLop) group by MaMonHoc ) group by BangDiem.MaMonHoc,MonHoc.TenMonHoc,MonHoc.SoHocPhan,HocKy.TenHocKy

GO
/****** Object:  StoredProcedure [dbo].[USP_getnameclass]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_getnameclass]
@maLop varchar(10)
as
begin
select TenLop from Lop where MaLop=@maLop 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getQuyenHanFor]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_getQuyenHanFor] 
@Username varchar(30)

as
select QuyenHan.MaQuyen as[Mã quyền]  from  QuyenHan
where QuyenHan.TaiKhoan=@Username and QuyenHan.ChoPhep =1
GO
/****** Object:  StoredProcedure [dbo].[USP_getSinhVienByLop]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getSinhVienByLop]
@maLop varchar(10)
as
begin
select MaSinhVien, CONCAT(Họ,' ',Ten) as [HoVaTen],  CONVERT(VARCHAR(10), NgaySinh, 101) as[NgaySinh] , (Case GioiTinh when 1 then 'Nam' when 0 then N'Nữ' end )as[Gender],QueQuan  ,GhiChu from SinhVien 
where SinhVien.MaLop = @maLop
end
GO
/****** Object:  StoredProcedure [dbo].[USP_getSinhVienDetail]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_getSinhVienDetail] 
@masv varchar(10)
as
select CONCAT(Họ,' ',Ten) as [Họ và tên],CONVERT(VARCHAR(10), NgaySinh, 101) as ngaySinh,(Case GioiTinh when 1 then 'Nam' when 0 then N'Nữ' end )as[Gender],QueQuan ,Lop.TenLop,Lop.MaKhoaHoc,NganhDaoTao.TenNganh,HeDaoTao.TenHe from SinhVien inner join Lop on SinhVien.MaLop = lop.MaLop inner join HeDaoTao on Lop.MaHeDaoTao = HeDaoTao.MaHe inner join NganhDaoTao on Lop.MaNganh = NganhDaoTao.MaNganh where MaSinhVien = @masv
GO
/****** Object:  StoredProcedure [dbo].[USP_getTieuChiRenLuyenChuaChambyMaSinhVien]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_getTieuChiRenLuyenChuaChambyMaSinhVien]
@maSinhVien varchar(10),
@maHocKy varchar(10),
@thamso int
as
begin

if(@thamso = 1)
select TieuChiRenLuyen.MaTieuChi , NoiDungTieuChi ,MucDiem as [Mức điểm tối đa] from TieuChiRenLuyen left join BangDiemRenLuyen on TieuChiRenLuyen.MaTieuChi = BangDiemRenLuyen.MaTieuChi inner join SinhVien on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien
where
(LopTruong is null or TuCham is null or GVCN is null or Khoa is null )and MaHocKy = @maHocKy and SinhVien.MaSinhVien =@maSinhVien

if @thamso =2
select TieuChiRenLuyen.MaTieuChi , NoiDungTieuChi,MucDiem as [Mức điểm tối đa] from TieuChiRenLuyen left join BangDiemRenLuyen on TieuChiRenLuyen.MaTieuChi = BangDiemRenLuyen.MaTieuChi inner join SinhVien on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien
where
(LopTruong is null and MaHocKy = @maHocKy) and SinhVien.MaSinhVien =@maSinhVien

if @thamso = 3
select TieuChiRenLuyen.MaTieuChi , NoiDungTieuChi,MucDiem as [Mức điểm tối đa] from TieuChiRenLuyen left join BangDiemRenLuyen on TieuChiRenLuyen.MaTieuChi = BangDiemRenLuyen.MaTieuChi inner join SinhVien on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien
where
TuCham is null and MaHocKy = @maHocKy and SinhVien.MaSinhVien =@maSinhVien


if @thamso = 4
select TieuChiRenLuyen.MaTieuChi , NoiDungTieuChi ,MucDiem as [Mức điểm tối đa]from TieuChiRenLuyen left join BangDiemRenLuyen on TieuChiRenLuyen.MaTieuChi = BangDiemRenLuyen.MaTieuChi inner join SinhVien on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien
where
GVCN is null and MaHocKy = @maHocKy and SinhVien.MaSinhVien =@maSinhVien

if @thamso = 5
select TieuChiRenLuyen.MaTieuChi , NoiDungTieuChi,MucDiem as [Mức điểm tối đa] from TieuChiRenLuyen left join BangDiemRenLuyen on TieuChiRenLuyen.MaTieuChi = BangDiemRenLuyen.MaTieuChi inner join SinhVien on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien
where
Khoa is null and MaHocKy = @maHocKy and SinhVien.MaSinhVien =@maSinhVien

  
end
GO
/****** Object:  StoredProcedure [dbo].[USP_grantQuyenHan]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[USP_grantQuyenHan] 
@maQuyen char(10), 
@taiKhoan varchar(30), 
@choPhep bit


as
begin
declare @dem as int

select @dem = count (TaiKhoan) from QuyenHan where TaiKhoan =@taiKhoan and MaQuyen = @maQuyen
if @dem >0
Update QuyenHan set ChoPhep = @choPhep
else
insert into QuyenHan values(@taiKhoan,@maQuyen,@choPhep)

end
GO
/****** Object:  StoredProcedure [dbo].[USP_KhoiTaoDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_KhoiTaoDiemRenLuyen]
 @maHocKy varchar(10)
as
begin
declare @massv as varchar(10)
declare @getSV CurSor
set @getSV =Cursor for
select MaSinhVien from SinhVien where SinhVien.trangthai =1
open @getSV Fetch next
from @getSV into @massv
while @@FETCH_STATUS =0
begin
insert into BangDiemRenLuyen (MaSinhVien,MaHocKy) values(@massv,@maHocKy)
fetch next
from @getSV into @massv
END
Close @getSV
Deallocate @getSV
end
GO
/****** Object:  StoredProcedure [dbo].[USP_KhoiTaoDiemRenLuyenSV]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc  [dbo].[USP_KhoiTaoDiemRenLuyenSV]
 @maSinhVien varchar(10),
 @maHocKy varchar(10)

 as
 declare @dem as int
 declare @maTC as  varchar(10)
declare @getTC CurSor
set @getTC = Cursor for
select MaTieuChi from TieuChiRenLuyen
open @getTC
Fetch next from @getTC into @maTC
while @@FETCH_STATUS=0
begin
set @dem=0
select @dem = count(MaSinhVien) from BangDiemRenLuyen where MaSinhVien = @maSinhVien and   MaHocKy = @maHocKy and MaTieuChi is null
 if(@dem >0)
 update BangDiemRenLuyen set MaTieuChi = @maTC where  MaSinhVien = @maSinhVien and   MaHocKy = @maHocKy
 else
insert into BangDiemRenLuyen (MaSinhVien,MaHocKy,MaTieuChi) values(@maSinhVien,@maHocKy,@maTC)

fetch next from @getTC into @maTC
end
close @getTC
Deallocate @getTC

GO
/****** Object:  StoredProcedure [dbo].[USP_KiemTraBangDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_KiemTraBangDiemRenLuyen]
@maHocKy varchar(10)

as
begin
declare @dem as int 
select @dem = count ( SinhVien.MaSinhVien )from
 BangDiemRenLuyen 
 right join SinhVien  on BangDiemRenLuyen.MaSinhVien = SinhVien.MaSinhVien 
 where SinhVien.trangthai >0  and BangDiemRenLuyen.MaHocKy = @maHocKy
 select @dem as [row]
end
GO
/****** Object:  StoredProcedure [dbo].[USP_KiemTraDiem]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_KiemTraDiem]
@malop varchar(10),
@maMonHoc varchar(10),
@maHocKy varchar(10)

as
begin
	select count(Stt) as [SL] from BangDiem inner join SinhVien on BangDiem.MaSinhVien = SinhVien.MaSinhVien where MaLop= @malop and MaHocKy = @maHocKy and MaMonHoc = @maMonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT username,displayName FROM dbo.ThongTinDangNhap WHERE username = @userName AND password = @passWord and status=1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_MaxDiemRenLuyen]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_MaxDiemRenLuyen]
@maTC varchar(10)
as
select MucDiem from TieuChiRenLuyen where MaTieuChi = @maTC
GO
/****** Object:  StoredProcedure [dbo].[USP_SelectHeDaoTao]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_SelectHeDaoTao]
as
begin
select MaHe as[Mã hệ],TenHe as [Tên hệ] from HeDaoTao 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_TinhDiemTBHK]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_TinhDiemTBHK]
@maHK varchar(10)
AS
BEGIN
	select BangDiem.MaSinhVien,CONCAT(Họ,' ',Ten) as [Họ và tên],Lop.TenLop,dbo.DiemTBC(BangDiem.MaSinhVien,@maHK) as [Điểm TBC],SinhVien.GhiChu from BangDiem inner join SinhVien on BangDiem.MaSinhVien =SinhVien.MaSinhVien inner join Lop on SinhVien.MaLop = Lop.MaLop where BangDiem.MaHocKy = @maHK 
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 1/9/18 1:06:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@userName varchar(30), @displayName NVARCHAR(50), @password varchar(30), @newPassword nvarchar(30)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.ThongTinDangNhap WHERE username = @userName AND password = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.ThongTinDangNhap SET displayName = @displayName WHERE username = @userName
		END		
		ELSE
			UPDATE dbo.ThongTinDangNhap SET displayName = @displayName, password = @newPassword WHERE username = @userName
	end
END
GO
