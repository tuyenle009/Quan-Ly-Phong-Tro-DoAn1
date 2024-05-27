CREATE DATABASE QuanLyPhongTroTYN
GO
USE QuanLyPhongTroTYN
GO

-- Tạo bảng Phòng trọ
CREATE TABLE PhongTro (
    MaPT CHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(50),
    GiaPhong FLOAT ,
    SLToiDa INT,
	TinhTrang BIT,
	AnhPhong IMAGE 
);
-- Tạo bảng Phiếu Chi
CREATE TABLE PhieuChi (
    MaPC CHAR(10) PRIMARY KEY,
	MaPT CHAR(10),
    NgayChi DATE ,
    SoTien FLOAT DEFAULT 0,
    LyDo NVARCHAR(100),
    FOREIGN KEY (MaPT) REFERENCES PhongTro(MaPT)
);

---- Tạo bảng Thiết bị
--CREATE TABLE ThietBi (
--    MaTB CHAR(10) PRIMARY KEY,
--    TenTB NVARCHAR(50),
--    Gia FLOAT CHECK (Gia >= 0),
--    SoLuong INT CHECK (SoLuong >= 0),
--    TinhTrang NVARCHAR(40) CHECK (TinhTrang IN (N'hoạt động', N'hỏng hóc', N'đang sửa chữa')),
--    MaPT CHAR(10),
--    FOREIGN KEY (MaPT) REFERENCES PhongTro(MaPT)
--);

-- Tạo bảng Khách trọ
CREATE TABLE KhachTro (
    MaKT CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(30),
    GioiTinh NCHAR(3) ,
    SDT CHAR(10) ,
    CMND CHAR(12) ,
	Email NCHAR(30),
    NgheNghiep NVARCHAR(40),
    DiaChi NVARCHAR(60)
);

-- Tạo bảng Hợp đồng
CREATE TABLE HopDong (
    MaHD CHAR(10) PRIMARY KEY,
    MaKT CHAR(10),
    MaPT CHAR(10),
    NgayThue DATE ,
    NgayKetThuc DATE,
    TienCoc FLOAT DEFAULT 0,
    TinhTrang BIT DEFAULT 0,
    FOREIGN KEY (MaKT) REFERENCES KhachTro(MaKT),
    FOREIGN KEY (MaPT) REFERENCES PhongTro(MaPT)
);
-- Chi tiet khach tro
CREATE TABLE ChiTietKT (
    MaKT CHAR(10),
	MaHD CHAR(10),
    FOREIGN KEY (MaHD) REFERENCES dbo.HopDong(MaHD),
	FOREIGN KEY (MaKT) REFERENCES dbo.KhachTro(MaKT),
	PRIMARY KEY (MaKT, MaHD)
);

-- Tạo bảng Dịch vụ điện nước
CREATE TABLE DienNuoc (
    MaDN CHAR(15) PRIMARY KEY,
	MaPT CHAR(10),
	Loai NChar(4),
	ThoiGian DATE,
	ChiSoCu INT DEFAULT 0,
	ChiSoMoi INT DEFAULT 0,
	DonGia FLOAT,
	ThanhTien FLOAT DEFAULT 0,
    FOREIGN KEY (MaPT) REFERENCES PhongTro(MaPT)
);
-- Tạo bảng Dịch vụ
CREATE TABLE DichVu (
    MaDV CHAR(10) PRIMARY KEY,
    TenDV NVARCHAR(40),
    DonGia FLOAT DEFAULT 0,
    DonViTinh CHAR(10)
);


-- Tạo bảng Quản lý thu tiền
CREATE TABLE PhieuThu (
    MaThu CHAR(10) PRIMARY KEY,
    MaPT CHAR(10),
	GiaPhong FLOAT,
    NgayThu DATE ,
	TongTien FLOAT DEFAULT 0,
	DaTra FLOAT DEFAULT 0,
	NoCu FLOAT DEFAULT 0,
	--ConLai FLOAT DEFAULT 0,
    FOREIGN KEY (MaPT) REFERENCES PhongTro(MaPT),
);

-- Tạo bảng Chi tiết quản lý thu tiền
CREATE TABLE ChiTietPhieuThu (
    MaThu CHAR(10),
    MaDV CHAR(10),
    SoLuong INT DEFAULT 0,
	--GiaPhong FLOAT DEFAULT 0,
    PRIMARY KEY (MaThu, MaDV),
    FOREIGN KEY (MaThu) REFERENCES PhieuThu(MaThu),
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);

--Tạo bảng quản lý người dùng
CREATE TABLE NguoiDung (
    TaiKhoan VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(50),
	Gmail VARCHAR(100),
    Quyen NVARCHAR(15)
);
--Tạo bảng phan quyen

CREATE TABLE PhanQuyen (
    Quyen NVARCHAR(15) PRIMARY KEY,
	QuyenPhongTro bit,
	QuyenPhieuChi bit,
	QuyenDichVu bit,
	QuyenPhieuThu bit,
	QuyenKhachTro bit,
	QuyenHopDong bit,
	QuyenThongKe bit,
	QuyenCaiDat bit

); 












