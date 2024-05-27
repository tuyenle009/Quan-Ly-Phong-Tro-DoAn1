CREATE FUNCTION TimKiemKhachTro
(
    @luachon INT,
    @tukhoa NVARCHAR(60)
)
RETURNS TABLE
AS
RETURN 
(
    SELECT * 
    FROM KhachTro
    WHERE 
        (
            @luachon = 1 AND MaKT = @tukhoa
        )
        OR
        (
            @luachon = 2 AND (
                MaKT LIKE '%' + @tukhoa + '%' OR
				Hoten LIKE '%' + @tukhoa + '%' OR
				CMND LIKE '%' + @tukhoa + '%' OR
				GioiTinh LIKE '%' + @tukhoa + '%' OR
				DiaChi LIKE '%' + @tukhoa + '%' OR
				SDT LIKE '%' + @tukhoa + '%' OR
				NgheNghiep LIKE '%' + @tukhoa + '%'
            )
        )
)

