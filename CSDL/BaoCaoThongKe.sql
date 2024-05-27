


--tìm những phòng đang được thuê theo khoảng thời gian
DECLARE @ngaytrc Date
DECLARE @ngaysau Date
set @ngaytrc = '2024-03-01'
set @ngaysau = '2024-8-01'
select * from HopDong where @ngaysau BETWEEN NgayThue and NgayKetThuc ;
select * from HopDong where (NgayKetThuc <= @ngaysau) or NgayThue>=@ngaysau ;

--hd chap nhan
ALTER FUNCTION dbo.Fn_HDTonTai
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	select * from HopDong where ( @ngayKT BETWEEN NgayThue and NgayKetThuc) and TinhTrang = 1
)


--thống kê mức tiêu thụ điện theo thời gian
 Alter FUNCTION dbo.Fn_ThongKeTieuThuDien
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	SELECT loai as [Loai], 
       SUM(CASE WHEN ChiSoMoi - ChiSoCu < 0 THEN 0 ELSE ChiSoMoi - ChiSoCu END) AS [MucTieuThu]
	FROM diennuoc
	WHERE mapt IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT))
	  AND ThoiGian BETWEEN @ngayBD AND @ngayKT
	GROUP BY loai
)

--thống kê phòng 
 ALTER FUNCTION dbo.Fn_TKPhongThue
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	SELECT 
    (SELECT COUNT(*) FROM PhongTro) AS [TongPhong],
    (SELECT COUNT(*) FROM PhongTro WHERE MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT))) AS [PhongDaThue],
    (SELECT COUNT(*) FROM PhongTro WHERE MaPT NOT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT))) AS [PhongChuaThue]
)


--thong kê thu tiền
 ALTER FUNCTION dbo.Fn_TKThuTien
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	SELECT 
    (SELECT COUNT(*) 
     FROM PhieuThu 
     WHERE MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) 
       AND NgayThu BETWEEN @ngayBD AND @ngayKT 
       AND DaTra > 0) AS [DaThu],

    (SELECT COUNT(*) 
     FROM PhieuThu 
     WHERE MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) 
       AND NgayThu BETWEEN @ngayBD AND @ngayKT 
       AND DaTra = 0) AS [ChuaThu]
)
--thong ke tong
 ALTER FUNCTION dbo.Fn_TKDichVu
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	SELECT 
	(SELECT ISNULL(SUM( ISNULL(CASE WHEN ThanhTien < 0 THEN 0 ELSE ThanhTien END,0)), 0) AS [Tiền điện] FROM diennuoc WHERE mapt IN (SELECT mapt from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT ) AND ThoiGian BETWEEN @ngayBD AND @ngayKT AND Loai = N'Điện') AS [TienDien],
	(SELECT ISNULL(SUM(  ISNULL(CASE WHEN ThanhTien < 0 THEN 0 ELSE ThanhTien END,0)), 0) AS [Tiền điện] FROM diennuoc WHERE mapt IN (SELECT mapt from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AND ThoiGian BETWEEN @ngayBD AND @ngayKT AND Loai = N'Nước') AS [TienNuoc],
	(select ISNULL(SUM(ISNULL(dv.DonGia*ctpt.SoLuong,0)),0) from dichvu as dv join ChiTietPhieuThu as ctpt on ctpt.MaDV = dv.MaDV join phieuthu as pt on pt.MaThu = ctpt.MaThu where pt.MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and (pt.NgayThu BETWEEN @ngayBD AND @ngayKT) ) AS [TienDVKhac],
	(select ISNULL(SUM(ISNULL(GiaPhong,0)),0) from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AS [TienPhong],
	(select ISNULL(SUM(ISNULL(NoCu,0)),0) from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AS [NoCu],
	(select ISNULL(SUM(ISNULL(TongTien,0)),0) from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AS [TongTien],
	(select ISNULL(SUM(ISNULL(DaTra,0)),0) from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AS [DaThu],
	(select ISNULL(SUM(ISNULL(TongTien-DaTra,0)),0) from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT) AS [ConLai]
)

--chi tiet dich vu
ALTER FUNCTION dbo.Fn_TKChitietDV
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	select ISNULL(dv.MaDV, '') AS MaDV,ISNULL(dv.TenDV, '') AS TenDV,   ISNULL(SUM(dv.DonGia*ctpt.SoLuong),0) as [Thanhtien]  from dichvu as dv 
	join ChiTietPhieuThu as ctpt on ctpt.MaDV = dv.MaDV
	join phieuthu as pt on pt.MaThu = ctpt.MaThu
	where pt.MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and (pt.NgayThu BETWEEN @ngayBD AND @ngayKT)
	GROUP BY dv.MaDV,dv.TenDV
	)



--tong hop
alter FUNCTION dbo.Fn_TKTongHop
(
	@ngayBD Date,
	@ngayKT Date
)
RETURNS TABLE
AS
RETURN (
	SELECT  
    (SELECT ISNULL([TongTien],0) FROM dbo.Fn_TKDichVu(@ngayBD, @ngayKT)) AS [TongThu],
    (SELECT SUM(ISNULL(SoTien, 0)) FROM PhieuChi WHERE MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) AND NgayChi BETWEEN @ngayBD AND @ngayKT) AS [TongChi],
    (SELECT ISNULL([TongTien],0) FROM dbo.Fn_TKDichVu(@ngayBD, @ngayKT)) - (SELECT SUM(ISNULL(SoTien, 0)) FROM PhieuChi WHERE MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) AND NgayChi BETWEEN @ngayBD AND @ngayKT) AS [LoiNhuan]
	)




--nháp

select  pt.MaThu, dv.MaDV, ctpt.SoLuong, ctpt.SoLuong*dv.don from dichvu as dv join ChiTietPhieuThu as ctpt on ctpt.MaDV = dv.MaDV join phieuthu as pt on pt.MaThu = ctpt.MaThu where pt.MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT))

select * from dbo.Fn_TKDichVu(@ngayBD,@ngayKT)

	

  

DECLARE @ngayBD DATE = '2024-05-1';
DECLARE @ngayKT DATE = '2024-05-30';   
select * from Fn_TKDichVu(@ngayBD,@ngayKT) 

select * from Fn_TKChitietDV(@ngayBD,@ngayKT) 

SELECT * FROM diennuoc WHERE mapt IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) AND ThoiGian BETWEEN @ngayBD AND @ngayKT AND Loai = N'Điện'
SELECT * FROM diennuoc WHERE mapt IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) AND ThoiGian BETWEEN @ngayBD AND @ngayKT AND Loai = N'Nước'

select * from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT
select * from Fn_TKDichVu(@ngayBD,@ngayKT) 

select * from Fn_HDTonTai(@ngayBD,@ngayKT) 
SELECT * FROM diennuoc WHERE mapt IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) AND ThoiGian BETWEEN @ngayBD AND @ngayKT AND Loai = N'Điện'
     
select * from PhieuThu where MaPT IN (SELECT mapt FROM dbo.Fn_HDTonTai(@ngayBD, @ngayKT)) and NgayThu BETWEEN @ngayBD AND @ngayKT
    


  
  
