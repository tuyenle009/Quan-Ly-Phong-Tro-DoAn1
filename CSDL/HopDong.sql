
ALTER FUNCTION TimKiemHopDong
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
    FROM dbo.HopDong
    WHERE 
        (
            @luachon = 1 AND MaHD = @tukhoa
        )
        OR
        (
            @luachon = 2 AND (
                MaHD LIKE '%' + @tukhoa + '%' OR
                MaKT LIKE '%' + @tukhoa + '%' OR
                MaPT LIKE '%' + @tukhoa + '%' OR
                CONVERT(NVARCHAR(20), NgayThue, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), NgayKetThuc, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), TienCoc) LIKE '%' + @tukhoa + '%' OR
                CAST(TinhTrang AS NVARCHAR(5)) = @tukhoa  -- Chuyển đổi bit thành chuỗi để tìm kiếm gần đúng
            )
        )
		 OR
        ( --tim kiem theo ngay thang
            @luachon = 3 AND (@thangnam BETWEEN ngaythue AND ngayketthuc)
			  AND (
                MaHD LIKE '%' + @tukhoa + '%' OR
                MaKT LIKE '%' + @tukhoa + '%' OR
                MaPT LIKE '%' + @tukhoa + '%' OR
                CONVERT(NVARCHAR(20), NgayThue, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), NgayKetThuc, 23) LIKE '%' + @tukhoa +'%' OR
                CONVERT(NVARCHAR(20), TienCoc) LIKE '%' + @tukhoa + '%' OR
                CAST(TinhTrang AS NVARCHAR(5)) = @tukhoa  -- Chuyển đổi bit thành chuỗi để tìm kiếm gần đúng
            )
        )
		OR
        (
		--tim kiem theo ngay thang
           @luachon = 6 AND (@thangnam BETWEEN ngaythue AND ngayketthuc)
        )
		OR
        (
		--hop dong da het han
            @luachon = 4
			  AND TinhTrang = 0
        )
		OR
        ( --hd chua het han
            @luachon = 5
			  AND TinhTrang = 1
        )
)
