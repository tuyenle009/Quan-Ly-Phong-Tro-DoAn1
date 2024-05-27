-- Chèn các bản ghi vào bảng DienNuoc
INSERT INTO DienNuoc (MaDN, MaPT, Loai, ThoiGian, ChiSoCu, ChiSoMoi, DonGia, ThanhTien) VALUES
('D1', 'PT1', N'Điện', '2024-04-27', 23, 90, 0, 115600),
('D2', 'PT2', N'Điện', '2024-04-27', 33, 88, 0, 94000),
('D3', 'PT3', N'Điện', '2024-04-27', 25, 78, 0, 90400),
('D4', 'PT1', N'Điện', '2024-05-29', 90, 110, 0, 34000),
('D5', 'PT2', N'Điện', '2024-05-29', 88, 110, 0, 37400),
('D6', 'PT3', N'Điện', '2024-05-29', 78, 0, 1700, 0),
('N1', 'PT1', N'Nước', '2024-04-27', 12, 32, 0, 130000),
('N2', 'PT2', N'Nước', '2024-04-27', 22, 44, 0, 148000),
('N3', 'PT3', N'Nước', '2024-04-27', 25, 68, 0, 337000),
('N4', 'PT1', N'Nước', '2024-05-29', 32, 80, 0, 382000),
('N5', 'PT2', N'Nước', '2024-05-29', 44, 0, 6000, 0),
('N6', 'PT3', N'Nước', '2024-05-29', 68, 0, 6000, 0);

-- Chèn các bản ghi vào bảng DichVu
INSERT INTO DichVu (MaDV, TenDV, DonGia, DonViTinh) VALUES
('DV001', N'Internet', 15000, N'Tháng'),
('DV002', N'Dọn Rác', 80000, N'Tháng'),
('DV3', N'Vệ sinh phòng', 80000, N'Tháng'),
('DV4', N'Thuê xe', 50000, N'Ngày');

-- Chèn các bản ghi vào bảng KhachTro
INSERT INTO KhachTro (MaKT, HoTen, GioiTinh, SDT, CMND, Email, NgheNghiep, DiaChi) VALUES
('KT1', N'Pham Thoa', N'Nữ', '0344001111', '033209002999', '_', N'Giáo viên', N'Tử Cầu - Hưng Yên'),
('KT10', N'Son GoKu', N'Nam', '0233224563', '033029220394', '_', N'Bảo vệ', N'Tiểu bang Namec'),
('KT11', N'Nguyễn Văn A', N'Nam', '0123456789', '123456789012', '_', N'Nhân viên kinh doanh', N'Hà Nội'),
('KT12', N'Trần Thị B', N'Nữ', '0987654321', '987654321098', '_', N'Kế toán viên', N'Hồ Chí Minh'),
('KT13', N'Phạm Văn C', N'Nam', '0369852147', '654321098765', '_', N'Lập trình viên', N'Đà Nẵng'),
('KT14', N'Lê Thị D', N'Nữ', '0321594876', '321098765432', '_', N'Quản lý sản xuất', N'Hải Phòng'),
('KT15', N'Trần Văn E', N'Nam', '0975321684', '789012345678', '_', N'Giáo viên', N'Cần Thơ'),
('KT16', N'Nguyễn Thị F', N'Nữ', '0398462157', '890123456789', '_', N'Chuyên viên marketing', N'Hà Giang'),
('KT17', N'Hoàng Văn G', N'Nam', '0912345678', '012345678901', '_', N'Bác sĩ', N'Hà Tĩnh'),
('KT18', N'Lê Thị H', N'Nữ', '0947532168', '901234567890', '_', N'Nhân viên bán hàng', N'Quảng Ninh'),
('KT2', N'Tiểu Lương Tử', N'Nữ', '0999339292', '0', '_', N'Sinh viên', N'Văn Lâm - Hà Nội'),
('KT3', N'Hoàng Tài', N'Nam', '032222331', '033204002888', '_', N'Hoc sinh', N'Đồng Than - Hà Nam'),
('KT4', N'Đức Hoa', N'Nữ', '0', '0', '_', N'Sinh Viên', N'Lạc Cầu - Yên Mỹ'),
('KT5', N'Lê Tuyển', N'Nam', '0999334344', '033232232232', '_', N'Kỹ sư AI', N'Văn Lâm - Hà Nội'),
('KT6', N'Văn Trường', N'Nam', '0333221211', '088788686878', '_', N'Vận động viên', N'ConTum - DăckLak'),
('KT7', N'Hoàng Phi Hồng', N'Nam', '0223313232', '033212223234', '_', N'Diễn viên', N'Tây Nguyên - Việt Nam'),
('KT8', N'Hồng Tử Diệp', N'Nữ', '0332324413', '022313442345', '_', N'Bác sĩ', N'Yên Mỹ - Phú Thọ'),
('KT9', N'Lưu Vĩ Dạ', N'Nữ', '0', '033204002222', '_', N'Diễn Viên', N'Lạc Hồng Phúc')

-- Chèn các bản ghi vào bảng HopDong
INSERT INTO HopDong (MaHD, MaKT, MaPT, NgayThue, NgayKetThuc, TienCoc, TinhTrang) VALUES
('HD1', 'KT1', 'PT1', '2024-03-01', '2024-07-01', 2000000, 1),
('HD2', 'KT2', 'PT2', '2024-04-01', '2024-08-01', 3000000, 1),
('HD3', 'KT3', 'PT3', '2024-04-01', '2024-08-01', 1500000, 1),
('HD4', 'KT4', 'PT4', '2024-04-01', '2024-10-01', 3000000, 1),
('HD5', 'KT5', 'PT5', '2024-04-12', '2024-09-01', 4000000, 1),
('HD6', 'KT6', 'PT6', '2024-05-27', '2024-07-01', 1000000, 1);

-- Chèn các bản ghi vào bảng NguoiDung
INSERT INTO NguoiDung (TaiKhoan, MatKhau, Gmail, Quyen) VALUES
('hoangphihong', '12345', 'devildragon409@gmail.com', N'Chủ trọ'),
('hoaxuan', '12345', 'hoasontaixuat@gmail.com', N'Chủ trọ'),
('trieutulong', '12345', 'lythuongkiet409@gmail.com', N'Chủ trọ'),
('tuyenle', '12345', 'leductuyen098@gmail.com', N'Khách trọ');

-- Chèn các bản ghi vào bảng PhieuThu
INSERT INTO PhieuThu (MaThu, MaPT, GiaPhong, NgayThu, TongTien, DaTra, NoCu) VALUES
('PTh1', 'PT1', 1000000, '2024-04-01', 1341800, 1000000, 1200),
('PTh10', 'PT1', 1000000, '2024-05-27', 2062800, 0, 341800),
('PTh2', 'PT4', 8500000, '2024-04-11', 8598000, 123000, 3000),
('PTh3', 'PT1', 9000000, '2024-03-11', 9350000, 9350000, 0),
('PTh4', 'PT2', 1000000, '2024-04-13', 1432000, 0, 0),
('PTh5', 'PT3', 5000000, '2024-04-01', 5639400, 540000, 2000),
('PTh6', 'PT3', 5000000, '2024-03-01', 5160000, 5160000, 0),
('PTh7', 'PT1', 9000000, '2024-05-26', 9757800, 0, 341800),
('PTh8', 'PT2', 1000000, '2024-05-27', 2469400, 0, 1432000);

-- Chèn các bản ghi vào bảng ChiTietPhieuThu
INSERT INTO ChiTietPhieuThu (MaThu, MaDV, SoLuong) VALUES
('PTh1', 'DV001', 1),
('PTh1', 'DV002', 1),
('PTh10', 'DV001', 1),
('PTh10', 'DV002', 3),
('PTh10', 'DV4', 1),
('PTh2', 'DV001', 1),
('PTh2', 'DV3', 1),
('PTh3', 'DV001', 2),
('PTh3', 'DV002', 4),
('PTh4', 'DV001', 2),
('PTh4', 'DV002', 2),
('PTh5', 'DV3', 2),
('PTh5', 'DV4', 1),
('PTh6', 'DV002', 2)

-- Chèn các bản ghi vào bảng ChiTietKT
INSERT INTO ChiTietKT (MaKT, MaHD) VALUES
('KT1', 'HD1'),
('KT10', 'HD1'),
('KT12', 'HD2'),
('KT13', 'HD2'),
('KT14', 'HD4'),
('KT15', 'HD5'),
('KT18', 'HD5'),
('KT2', 'HD2'),
('KT3', 'HD3'),
('KT4', 'HD4'),
('KT5', 'HD5'),
('KT6', 'HD6'),
('KT7', 'HD6'),
('KT8', 'HD4'),
('KT9', 'HD1')