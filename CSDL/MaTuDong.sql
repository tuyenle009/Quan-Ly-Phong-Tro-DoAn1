--khach tro

CREATE FUNCTION maTuDongKT()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaKT, 3, LEN(MaKT)) AS INT)) FROM dbo.KhachTro )
	IF @STT IS NULL SET @STT =0
	RETURN 'KT' + CONVERT(VARCHAR(10),@STT+1)
END

--phong tro

create FUNCTION maTuDongPT()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaPT, 3, LEN(MaPT)) AS INT)) FROM dbo.PhongTro )
	IF @STT IS NULL SET @STT =0
	RETURN 'PT' + CONVERT(VARCHAR(10),@STT+1)
END
GO
--Quản lý phiếu thu
ALTER FUNCTION maTuDongPThu()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaThu, 4, LEN(MaThu)) AS INT)) FROM dbo.PhieuThu )
	IF @STT IS NULL SET @STT =0
	RETURN 'PTh' + CONVERT(VARCHAR(10),@STT+1)
END
--Quản lý dịch vụ
CREATE FUNCTION maTuDongDV()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaDV, 3, LEN(MaDV)) AS INT)) FROM dbo.DichVu )
	IF @STT IS NULL SET @STT =0
	RETURN 'DV' + CONVERT(VARCHAR(10),@STT+1)
END
--Quản lý hợp đồng

CREATE FUNCTION maTuDongHD()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaHD, 3, LEN(MaHD)) AS INT)) FROM dbo.HopDong )
	IF @STT IS NULL SET @STT =0
	RETURN 'HD' + CONVERT(VARCHAR(10),@STT+1)
END
--Quản lý phiếu chi
CREATE FUNCTION maTuDongPC()
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	SET @STT = (SELECT MAX(CAST(SUBSTRING(MaPC, 3, LEN(MaPC)) AS INT)) FROM dbo.PhieuChi )
	IF @STT IS NULL SET @STT =0
	RETURN 'PC' + CONVERT(VARCHAR(10),@STT+1)
END

GO
--chen du lieu
--pt true
--kt true
--hopdong true

-----------------------------------------------------------------------------------------------------------------------------
--tạo hàm trả về mã điện nước tự động

ALTER FUNCTION maTuDongDN( @MaDN CHAR(1) )
RETURNS CHAR(10)
AS 
BEGIN
    DECLARE @STT INT
	IF @MaDN ='D'
	BEGIN
	    SET @STT = (SELECT MAX(CAST(SUBSTRING(MaDN, 2, LEN(MaDN)) AS INT)) FROM dbo.DienNuoc WHERE  LEFT(MaDN, 1)='D') --(LEN(RTRIM(MaDN))<9) AND
		IF @STT IS NULL SET @STT =0
		RETURN 'D' + CONVERT(VARCHAR(10),@STT+1)
	END
	ELSE
    BEGIN
         SET @STT = (SELECT MAX(CAST(SUBSTRING(MaDN, 2, LEN(MaDN)) AS INT)) FROM dbo.DienNuoc WHERE LEFT(MaDN, 1)='N') -- (LEN(RTRIM(MaDN))<9) AND
		 IF @STT IS NULL SET @STT =0
		 RETURN 'N' + CONVERT(VARCHAR(10),@STT+1)
    END
	RETURN '.'
END

GO

SELECT LEN(RTRIM(MaDN)),MaDN FROM dbo.DienNuoc


SELECT * FROM dbo.DienNuoc

SELECT dbo.maTuDongDN('N')
INSERT INTO dbo.DienNuoc
VALUES
(   dbo.maTuDongDN('N'),        -- MaDN - char(10)
    'P01',        -- MaPT - char(10)
    '2023-01-01', -- TuNgay - date
    GETDATE(), -- ToiNgay - date
    0,         -- ChiSoCu - int
    0,         -- ChiSoMoi - int
    0.0,       -- DonGia - float
    0.0        -- ThanhTien - float
    )