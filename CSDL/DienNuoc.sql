
--ham tinh tien dien, tien nuoc
CREATE FUNCTION TinhTienDien(@soCu int, @soMoi int)
RETURNS float
AS 
BEGIN
	DECLARE @sodien INT
	SET @sodien = @soMoi -@soCu
    DECLARE @tonggia FLOAT
    IF @sodien <= 50
        SET @tonggia = @sodien * 1700
    ELSE IF @sodien <= 100
        SET @tonggia = 50 * 1700 + (@sodien - 50) * 1800
    ELSE IF @sodien <= 200
        SET @tonggia = 50 * 1700 + 50 * 1800 + (@sodien - 100) * 2000
    ELSE
        SET @tonggia = 50 * 1700 + 50 * 1800 + 100 * 2000 + (@sodien - 200) * 2500
    RETURN @tonggia
END


CREATE FUNCTION TinhTienNuoc(@soCu int, @soMoi int)
RETURNS float
AS 
BEGIN
    DECLARE @tonggia FLOAT
	DECLARE @sonuoc INT
	SET @sonuoc = @soMoi -@soCu
    IF @sonuoc <= 10
        SET @tonggia = @sonuoc * 6000
    ELSE IF @sonuoc <= 20
        SET @tonggia = 10 * 6000 + (@sonuoc - 10) * 7000
    ELSE
        SET @tonggia = 10 * 6000 + 10 * 7000 + (@sonuoc - 20) * 9000
    RETURN @tonggia
END

--------------------------LẤY DỮ LIỆU CŨ THÁNG TRƯỚC THÀNH DỮ LIỆU MỚI THÁNG NÀY-----------------------------

--tạo hàm trả về giá trị kiểm tra
ALTER FUNCTION fn_KiemTraDNPhong
(
    @maPT CHAR(10),
    @thang INT,
    @nam INT,
	@keyWord char(1)
)
RETURNS BIT
AS
BEGIN
    DECLARE @result BIT
    
    IF EXISTS (
        SELECT * 
        FROM dbo.DienNuoc dn 
        JOIN dbo.PhongTro pt ON pt.MaPT = dn.MaPT 
        WHERE pt.MaPT = @maPT 
        AND MONTH(dn.ThoiGian) = @thang - 1 
        AND YEAR(dn.ThoiGian) = @nam
		AND LEFT(dn.MaDN,1) = @keyWord
    ) --kiểm tra xem có đúng là mã điện or nước và tháng đúng bằng tháng yêu cầu hay không
        SET @result = 1; -- True
    ELSE
        SET @result = 0; -- False

    RETURN @result
END



--thủ tục chèn thông tin vào diennuoc
GO

ALTER PROCEDURE SP_ThemThongTinDN 
 @soMoi INT,
 @toiNgay DATE,
 @thang INT,
 @nam INT,
 @maPT CHAR(10),
 @donGia FLOAT,
 @keyWord CHAR(1)
AS
BEGIN
    SELECT @soMoi = dn.ChiSoMoi, @toiNgay = dn.ThoiGian FROM dbo.DienNuoc dn JOIN dbo.PhongTro pt 
		ON pt.MaPT = dn.MaPT AND pt.MaPT = @maPT AND MONTH(dn.ThoiGian) = @thang-1 AND YEAR(dn.ThoiGian) = @nam AND LEFT(dn.MaDN, 1) = @keyWord

		IF @thang = 13
		BEGIN
		SET @thang = 1; -- Gán lại giá trị 12 nếu @thang ban đầu bằng 1
		SET @nam = @nam +1
		END
		BEGIN TRY
		
		--kiểm tra tháng định thêm có tồn tại điện or nước của phòng sẵn rồi không | nếu không thi thêm điện or nước của phòng
		   
		IF NOT EXISTS (
			SELECT * 
			FROM dbo.DienNuoc dn 
			JOIN dbo.PhongTro pt ON pt.MaPT = dn.MaPT 
			WHERE pt.MaPT = @maPT 
			AND MONTH(dn.ThoiGian) = @thang
			AND YEAR(dn.ThoiGian) = @nam
			AND LEFT(dn.MaDN,1) = @keyWord
		) --kiểm tra xem có đúng là mã điện or nước và tháng đúng bằng tháng yêu cầu hay không
			INSERT INTO dbo.DienNuoc
			VALUES --chen thông tin điện
			(   dbo.maTuDongDN(@keyWord), --  EG: DP001.223   
				@maPT,        -- MaPT - char(10)
				case when @keyWord ='D' then N'Điện' else N'Nước' END, -- TuNgay - date
				CONVERT(CHAR(10),@nam)+'-'+CONVERT(CHAR(10), @thang)+'-29', -- ToiNgay - date
				ISNULL(@soMoi,0),         -- ChiSoCu - int
				0,         -- ChiSoMoi - int
				@donGia,       -- DonGia - float
				0.0   )     -- ThanhTien - float

		-- Nếu có thì cần update
		ELSE UPDATE DienNuoc set  ChiSoCu = ISNULL(@soMoi,0), ChiSoMoi = 0 where MaPT = @maPT AND MONTH(ThoiGian) = @thang AND YEAR(ThoiGian) = @nam AND LEFT(MaDN,1) = @keyWord
		END TRY
		BEGIN CATCH
		END CATCH
END

--cai dat 
ALTER PROCEDURE SP_LayDLThangTruoc
	@thang INT,
	@nam INT
AS
BEGIN
DECLARE @maPT CHAR(10)
DECLARE update_cursor CURSOR FOR
    SELECT MaPT
    FROM dbo.PhongTro

OPEN update_cursor
FETCH NEXT FROM update_cursor INTO @maPT
WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE @soMoi INT
	DECLARE @toiNgay DATE --lấy ra ngày thanh toán của tháng trước
	--thiết đặt nếu tháng là 1 sẽ phải quay ngược về 12

	IF @thang = 1
	BEGIN
    SET @thang = 13 ; -- Gán lại giá trị 12 nếu @thang ban đầu bằng 1
	SET @nam = @nam -1
	END
	
	--kiểm tra xem đã thiết đặt thông tin của tháng trước chưa để lấy ra thông tin

	IF(dbo.fn_KiemTraDNPhong(@maPT,@thang,@nam,N'D')=1 or dbo.fn_KiemTraDNPhong(@maPT,@thang,@nam,N'N')=1) --kiểm tra có mã điện  hoặc mã nước tháng trước không
	BEGIN
		-- nếu có mã điện tháng trước thì update điện
		IF(dbo.fn_KiemTraDNPhong(@maPT,@thang,@nam,N'D')=1) 
		    EXEC dbo.SP_ThemThongTinDN @soMoi,@toiNgay,@thang,@nam,@maPT,1700,'D'
		-- nếu có mã nước thì update nước
		IF(dbo.fn_KiemTraDNPhong(@maPT,@thang,@nam,N'N')=1)
			EXEC dbo.SP_ThemThongTinDN @soMoi,@toiNgay,@thang,@nam,@maPT,6000,'N'

		FETCH NEXT FROM update_cursor INTO @maPT
	END
	ELSE 
		FETCH NEXT FROM update_cursor INTO @maPT
END
CLOSE update_cursor
DEALLOCATE update_cursor
END
GO

---------------------------------FUNCTION UPDATE DIEN NUOC-----------------------------
----"UPDATE DienNuoc SET MaPT = '" + dichVu.MaPT + "', ThoiGian = '" + dichVu.ThoiGian + "', ChiSoCu = " + dichVu.ChiSoCu + ", ChiSoMoi = " + dichVu.ChiSoMoi + ", DonGia = " + 0 +$",ThanhTien =  dbo.TinhTienNuoc({dichVu.ChiSoCu},{dichVu.ChiSoMoi})" + " WHERE MaDN = '" + dichVu.MaDN + "'"
--ALTER PROCEDURE SP_ThemThongTinDN2 --thêm thông tin thuần đn mà không phải lấy dữ liệu 
-- @soCu int,
-- @soMoi INT,
-- @thang INT,
-- @nam INT,
-- @maPT CHAR(10),
-- @donGia FLOAT,
-- @keyWord CHAR(1)
--AS
--BEGIN
--		--kiểm tra tháng định thêm có tồn tại điện or nước của phòng rồi không | nếu không thi thêm điện or nước của phòng
--		IF NOT EXISTS (
--			SELECT * 
--			FROM dbo.DienNuoc dn 
--			JOIN dbo.PhongTro pt ON pt.MaPT = dn.MaPT 
--			WHERE pt.MaPT = @maPT 
--			AND MONTH(dn.ThoiGian) = @thang
--			AND YEAR(dn.ThoiGian) = @nam
--			AND LEFT(dn.MaDN,1) = @keyWord
--		) --kiểm tra xem có đúng là mã điện or nước và tháng đúng bằng tháng yêu cầu hay không
--			INSERT INTO dbo.DienNuoc
--			VALUES --chen thông tin điện
--			(   dbo.maTuDongDN(@keyWord), --  EG: DP001.223   
--				@maPT,        -- MaPT - char(10)
--				case when @keyWord ='D' then N'Điện' else N'Nước' END, -- TuNgay - date
--				CONVERT(VARCHAR(10),@nam)+'-'+CONVERT(VARCHAR(10), @thang)+'-29', -- ToiNgay - date
--				ISNULL(@soCu,0),         -- ChiSoCu - int
--				ISNULL(@soMoi,0),         -- ChiSoMoi - int
--				@donGia,       -- DonGia - float
--				0.0)     -- ThanhTien - float
--		ELSE
--			INSERT INTO dbo.DienNuoc
--			VALUES --chen thông tin điện
--			(   dbo.maTuDongDN(@keyWord), --  EG: DP001.223   
--				@maPT,        -- MaPT - char(10)
--				case when @keyWord ='D' then N'Điện' else N'Nước' END, -- TuNgay - date
--				CONVERT(VARCHAR(10),@nam)+'-'+CONVERT(VARCHAR(10), @thang)+'-29', -- ToiNgay - date
--				ISNULL(@soCu,0),         -- ChiSoCu - int
--				ISNULL(@soMoi,0),         -- ChiSoMoi - int
--				@donGia,       -- DonGia - float
--				0.0)     -- ThanhTien - float

--END

--EXEC dbo.SP_ThemThongTinDN2 2,3,2,2023,'PT1',200,'D'
