--tim kiem
alter FUNCTION TimKiemPhongTro
(
    @luachon INT,
    @tukhoa NVARCHAR(60)
)
RETURNS TABLE
AS
RETURN 
(
		SELECT * 
		FROM dbo.PhongTro
		WHERE 
			(
				@luachon = 1 AND MaPT = @tukhoa
			)
			OR
			(
				@luachon = 2 AND (
					MaPT LIKE '%' + @tukhoa + '%' OR
					TenPhong LIKE '%' + @tukhoa + '%' OR
					GiaPhong LIKE '%' + @tukhoa + '%' OR
					TinhTrang LIKE '%' + @tukhoa + '%' OR
					SLToiDa LIKE '%' + @tukhoa + '%' 
				)
			)
)

select * from PhongTro where mapt in (
select pt.mapt from PhongTro as pt join HopDong as hd on pt.MaPT = hd.MaPT where hd.TinhTrang=1)