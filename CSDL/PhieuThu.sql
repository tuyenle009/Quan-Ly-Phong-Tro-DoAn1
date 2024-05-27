ALTER PROCEDURE SP_UpTongTienPT
AS
BEGIN
DECLARE @MaThu CHAR(10)
DECLARE @TongTien FLOAT

DECLARE update_cursor CURSOR FOR
    SELECT MaThu
    FROM PhieuThu

OPEN update_cursor
FETCH NEXT FROM update_cursor INTO @MaThu

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @TongTien = (
        SELECT SUM(
            ISNULL(dv.DonGia * ctpt.SoLuong,0)
        )
        FROM ChiTietPhieuThu ctpt
        INNER JOIN DichVu DV ON ctpt.MaDV = DV.MaDV
        WHERE ctpt.MaThu = @MaThu
    )
    UPDATE PhieuThu
    SET TongTien = Isnull(@TongTien,0)
    WHERE MaThu = @MaThu

    FETCH NEXT FROM update_cursor INTO @MaThu
END
CLOSE update_cursor
DEALLOCATE update_cursor
END
GO
EXEC SP_UpTongTienPT
SELECT * FROM dbo.PhieuThu
select * from ChiTietPhieuThu

--tinh tong tien phieu thu
ALTER FUNCTION Fn_UpTongTienPT(@MaThu char(10), @mapt Char(10), @ngaythu date, @tienPhong FLOAT, @noCu float)
RETURNS FLOAT
AS 
BEGIN
	--tinh tien dich vu
	DECLARE @tienDV FLOAT
	--DECLARE @tienPhong FLOAT
	--DECLARE @tienDaTra FLOAT
	DECLARE @tienDien FLOAT
	DECLARE @tienNuoc FLOAT
	DECLARE @tongTien FLOAT


    SET @tienDV = (
    SELECT SUM(
        ISNULL(dv.DonGia * ctpt.SoLuong,0)
    )
    FROM ChiTietPhieuThu ctpt
    INNER JOIN DichVu DV ON ctpt.MaDV = DV.MaDV
    WHERE ctpt.MaThu = @MaThu
	)
	--lay số tiền còn lại của tháng trước làm nợ của tháng này
	DECLARE @thang INT
	DECLARE @nam INT
	SELECT 
    @thang = CASE WHEN MONTH(@ngaythu) = 1 THEN 13 ELSE MONTH(@ngaythu) END,
    @nam = CASE WHEN MONTH(@ngaythu) = 1 THEN YEAR(@ngaythu) - 1 ELSE YEAR(@ngaythu) END;
	--lay no cu
	--select TOP 1 @NoCu = ISNULL(TongTien - Datra, 0) from phieuthu where mapt = @mapt and month(NgayThu)=@thang-1 and year(NgayThu)=@nam

	
	--tien dien 
	select @tienDien = ThanhTien from DienNuoc where MaPT = @mapt and Loai = N'Điện' and month(@ngaythu)=month(thoigian) and year(@ngaythu)=year(ThoiGian)
	--tien nuoc
	select @tienNuoc = ThanhTien from DienNuoc where MaPT = @mapt and Loai = N'Nước' and month(@ngaythu)=month(thoigian) and year(@ngaythu)=year(ThoiGian)
	SET @tongTien =isnull(@tienDV,0)+isnull(@tienPhong,0)+isnull(@tienDien,0)+isnull(@tienNuoc,0)+isnull(@nocu,0)
	return @tongTien
END


select dbo.Fn_UpTongTienPT('PTh5','PT1','2024-04-13',9000000)
Update PhieuThu SET Tongtien = dbo.Fn_UpTongTienPT('PTh5','PT1','2024-04-13',9000000) where mathu = 'PTh5'




SELECT SUM(
        ISNULL(dv.DonGia * ctpt.SoLuong,0)
    )
    FROM ChiTietPhieuThu ctpt
    INNER JOIN DichVu DV ON ctpt.MaDV = DV.MaDV
    WHERE ctpt.MaThu = 'PTh5'

	select dv.DonGia,ctpt.SoLuong
	FROM ChiTietPhieuThu ctpt
    INNER JOIN DichVu DV ON ctpt.MaDV = DV.MaDV
    WHERE ctpt.MaThu = 'PTh5'


--lay ra gia phong tro
ALTER FUNCTION GiaPhong( @mapt Char(10))
RETURNS FLOAT
AS 
BEGIN
    DECLARE @GiaPhong FLOAT
	SET @GiaPhong = (SELECT giaphong FROM dbo.PhongTro where mapt = @mapt )
	RETURN isnull(@GiaPhong,0) 
END

select dbo.GiaPhong('pt1')

--lay ra tien dien tien nuoc

ALTER FUNCTION GiaDienNuoc( @mapt Char(10), @thoiGian date, @Loai  Char(1))
RETURNS FLOAT
AS 
BEGIN
    DECLARE @GiaDienNuoc FLOAT
	IF @Loai = 'D'
	BEGIN
		SET @GiaDienNuoc = (SELECT ThanhTien  FROM dbo.DienNuoc where mapt = @mapt and month(ThoiGian)=  month(@ThoiGian) and  year(ThoiGian)=  year(@ThoiGian) and Loai=N'Điện' )
	END
	ELSE
	BEGIN
		SET @GiaDienNuoc = (SELECT ThanhTien  FROM dbo.DienNuoc where mapt = @mapt and month(ThoiGian)=  month(@ThoiGian) and  year(ThoiGian)=  year(@ThoiGian) and  Loai=N'Nước' )
	END
	RETURN isnull(@GiaDienNuoc,0) 
END

select dbo.GiaPhong('PT1')

--tim kiem phieu thu
ALTER FUNCTION TimKiemPhieuThu
(
    @luachon INT,
    @tukhoa NVARCHAR(60),
	@thangnam date
)
RETURNS TABLE
AS
RETURN 
(
    SELECT * 
    FROM dbo.PhieuThu
    WHERE 
        (
            @luachon = 1 AND MaThu = @tukhoa
        )
        OR
        (
            @luachon = 2 AND (
                MaThu LIKE '%' + @tukhoa + '%' OR
                MaPT LIKE '%' + @tukhoa + '%' OR
                CONVERT(NVARCHAR(20), NgayThu, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), TongTien) LIKE '%' + @tukhoa + '%' OR
				CONVERT(NVARCHAR(20), Giaphong) LIKE '%' + @tukhoa + '%' OR
				CONVERT(NVARCHAR(20), DaTra) LIKE '%' + @tukhoa + '%'
            )
        )
		OR
        (
            @luachon = 3 AND MONTH(@thangnam)=month(NgayThu) 
			  AND year(@thangnam)=year(NgayThu)
			AND (
               (TongTien - DaTra) >0
            )
        )
		OR
        (
            @luachon = 4 AND MONTH(@thangnam)=month(NgayThu) 
			  AND year(@thangnam)=year(NgayThu)
			AND (
               (TongTien - DaTra) <= 0
            )
        )
		OR
        (
             @luachon = 5 AND MONTH(@thangnam)=month(NgayThu) 
			  AND year(@thangnam)=year(NgayThu)
			  AND (
                MaThu LIKE '%' + @tukhoa + '%' OR
                MaPT LIKE '%' + @tukhoa + '%' OR
                CONVERT(NVARCHAR(20), NgayThu, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), TongTien) LIKE '%' + @tukhoa + '%' OR
				CONVERT(NVARCHAR(20), Giaphong) LIKE '%' + @tukhoa + '%' OR
				CONVERT(NVARCHAR(20), DaTra) LIKE '%' + @tukhoa + '%'
            )
        )
		OR
        (
             @luachon = 6 AND MONTH(@thangnam)=month(NgayThu) 
			  AND year(@thangnam)=year(NgayThu)
        )
)

select * from phieuthu where (TongTien - DaTra)  <=0


--select pthu.MaThu, pt.TenPhong, pthu.NgayThu, pthu.GiaPhong, dn.Loai, dn.ChiSoCu, dn.ChiSoMoi, dn.ThanhTien , dn.ThoiGian,  pthu.NoCu,pthu.TongTien, 
--pthu.TongTien-pthu.DaTra as 'ConLai'
--from PhieuThu as pthu join phongtro as pt on pt.MaPT = pthu.MaPT 
--join DienNuoc as dn on dn.MaPT = pt.MaPT and month(dn.ThoiGian) = month(pthu.NgayThu) and year(dn.ThoiGian) = year(pthu.NgayThu)
--join ChiTietPhieuThu as ctpt on ctpt.MaThu = pthu.MaThu 
--join DichVu as dv on dv.MaDV = ctpt.MaDV
--where pthu.MaThu = 'pth1'
--group by 
--    pthu.MaThu, 
--    pt.TenPhong, 
--    pthu.NgayThu, 
--    pthu.GiaPhong, 
--    dn.Loai, 
--    dn.ChiSoCu, 
--    dn.ChiSoMoi, 
--    dn.ThanhTien, 
--    dn.ThoiGian,  
--    pthu.NoCu,
--    pthu.TongTien, 
--    pthu.TongTien - pthu.DaTra
----dv.TenDV,ctpt.SoLuong,





--in ra dịch vu trong 1 phieu thu
CREATE FUNCTION Fn_XuatDichVu
(
    @mapt CHAR(10)
)
RETURNS TABLE
AS
RETURN 
(
    SELECT dv.TenDV, ctpt.SoLuong 
    FROM dbo.PhieuThu as pt join ChiTietPhieuThu as ctpt on ctpt.MaThu = pt.MaThu 
	join DichVu as dv on dv.MaDV = ctpt.MaDV where pt.MaThu = @mapt
)
--in ra toan bo phieu thu theo thang
ALTER FUNCTION Fn_XuatToanBoPThu
(
    @thang int,
	@nam int
)
RETURNS TABLE
AS
RETURN 
(
   select MaThu, MaPT, GiaPhong, NgayThu, NoCu, TongTien, DaTra, TongTien-DaTra as 'ConLai'  from PhieuThu where month(NgayThu)= @thang and year(NgayThu)=@nam
)
-- NO CU
ALTER FUNCTION Fn_NoCu
(
    @mapt CHAR(10),
    @thangNam DATE
)
RETURNS FLOAT
AS
BEGIN
    -- Tính toán tháng và năm
    DECLARE @NoCu FLOAT;

    SELECT TOP 1 @NoCu = ISNULL(TongTien - Datra, 0)
    FROM phieuthu
    WHERE
        mapt = @mapt
        AND MONTH(NgayThu) = CASE WHEN MONTH(@thangNam) = 1 THEN 12 ELSE MONTH(@thangNam) - 1 END
        AND YEAR(NgayThu) = CASE WHEN MONTH(@thangNam) = 1 THEN YEAR(@thangNam) - 1 ELSE YEAR(@thangNam) END;

    RETURN isnull(@NoCu,0);
END;
