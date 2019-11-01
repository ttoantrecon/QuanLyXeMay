CREATE DATABASE QuanLyXeMay
GO

USE QuanLyXeMay
GO

-- Xe
-- PhuTung
-- SanPham
-- KhachHang
-- NhanVien
-- LoaiNhanVien
-- DangNhap
-- HoaDonNhap
-- CTHDNhap
-- HoaDonBan
-- CTHDBan

CREATE TABLE Xe
(
	Ma VARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	Loai NVARCHAR(100) NOT NULL,
	DonGia INT NOT NULL,
	Mau NVARCHAR(100) NOT NULL,
	Hang NVARCHAR(100) NOT NULL,
	DungTich NVARCHAR(100) NOT NULL,
	SoLuongTonKho INT NOT NULL
)
GO

CREATE TABLE PhuTung
(
	Ma VARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	DonGia INT NOT NULL,
	SoLuongTonKho INT NOT NULL
)
GO

CREATE TABLE SanPham
(
	MaSP VARCHAR(10) PRIMARY KEY,
	TenSP NVARCHAR(100) NOT NULL,
	DonGia INT NOT NULL
)
GO

CREATE TABLE KhachHang
(
	Ma VARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL CHECK(GioiTinh IN (N'Nam', N'Nữ')),
	CMND VARCHAR(20) NOT NULL,
	SDT VARCHAR(20) NOT NULL
)
GO

CREATE TABLE NhanVien
(
	Ma VARCHAR(10) PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL CHECK(GioiTinh IN (N'Nam', N'Nữ')),
	CMND VARCHAR(20) NOT NULL,
	SDT VARCHAR(20) NOT NULL,
	Luong INT NOT NULL
)
GO

CREATE TABLE LoaiNhanVien
(
	MaLoai VARCHAR(10) PRIMARY KEY,
	MaNV VARCHAR(10) NOT NULL,
	Ten NVARCHAR(100) NOT NULL

	FOREIGN KEY(MaNV) REFERENCES NhanVien(Ma) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

CREATE TABLE DangNhap
(
	TenDN VARCHAR(100) NOT NULL PRIMARY KEY,
	MatKhau VARCHAR(100) NOT NULL,
	LoaiTaiKhoan NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE HoaDonNhap
(
	Ma VARCHAR(10) PRIMARY KEY,
	MaNV VARCHAR(10) NOT NULL,
	NhaCC NVARCHAR(100) NOT NULL,
	NgayNhap DATE NOT NULL

	FOREIGN KEY(MaNV) REFERENCES NhanVien(Ma) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

CREATE TABLE CTHDNhap
(
	MaCTHDNhap INT IDENTITY PRIMARY KEY,
	MaHDNhap VARCHAR(10) NOT NULL,
	Ma VARCHAR(10) NOT NULL,
	SoLuong INT NOT NULL

	FOREIGN KEY(MaHDNhap) REFERENCES HoaDonNhap(Ma) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

CREATE TABLE HoaDonBan
(
	Ma VARCHAR(10) PRIMARY KEY,
	MaNV VARCHAR(10) NOT NULL,
	MaKH VARCHAR(10) NOT NULL,
	NgayNhap DATE NOT NULL

	FOREIGN KEY(MaNV) REFERENCES NhanVien(Ma) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY(MaKH) REFERENCES KhachHang(Ma) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

CREATE TABLE CTHDBan
(
	MaCTHDBan INT IDENTITY PRIMARY KEY,
	MaHDBan VARCHAR(10) NOT NULL,
	Ma VARCHAR(10) NOT NULL,
	SoLuong INT NOT NULL

	FOREIGN KEY(MaHDBan) REFERENCES HoaDonBan(Ma) ON UPDATE CASCADE ON DELETE CASCADE
)
GO


-- Nhap Bang Xe
--INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('', N'', N'', N'', N'', N'', N'', 0)
INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('X01', N'Winner 150', N'Xe Tay Ga', 10000000, N'Đen', N'Honda', N'100cc', 5)
INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('X02', N'Yamaha NVX 125 Deluxe', N'Xe Tay Ga', 20000000, N'Đen Nhám', N'Yamaha', N'125cc', 5)
INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('X03', N'BENELLI TNT125', N'Xe Tay Côn', 30000000, N'Trắng', N'BENELLI', N'200cc', 5)
INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('X04', N'Exciter RC 2020', N'Xe Tay Ga', 40000000, N'Xanh', N'Exciter', N'300cc', 5)
INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('X05', N'Cub 81 Espero', N'Xe Cub', 50000000, N'Vàng', N'Espero', N'400cc', 5)
GO

-- Nhap Bang PhuTung
--INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('', N'', '', 0)
INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('PT01', N'Ốp đuôi pô', 120000, 10)
INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('PT02', N'Ốp đèn soi biển số', 120000, 20)
INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('PT03', N'Ốp bầu lọc gió', 195000, 30)
INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('PT04', N'Ốp gác chân sau', 130000, 40)
INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('PT05', N'Thảm lót chân', 140000, 50)
GO

-- Nhap Bang SanPham
--INSERT INTO dbo.SanPham(MaSP, TenSP)VALUES('', N'')
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('X01', N'Winner 150', 10000000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('X02', N'Yamaha NVX 125 Deluxe', 20000000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('X03', N'BENELLI TNT125', 30000000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('X04', N'Exciter RC 2020', 40000000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('X05', N'Cub 81 Espero', 50000000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('PT01', N'Ốp đuôi pô', 120000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('PT02', N'Ốp đèn soi biển số', 120000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('PT03', N'Ốp bầu lọc gió', 195000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('PT04', N'Ốp gác chân sau', 130000)
INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) VALUES('PT05', N'Thảm lót chân', 140000)
GO

-- Nhap Bang KhachHang
--INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('', N'', N'', GETDATE(), N'', '', '') mm/dd/yyyy
INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('KH01', N'Chu Anh Toàn', N'TP.HCM', '9-13-1998', N'Nam', '213213213213', '0213213213')
INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('KH02', N'Nguyễn Văn Kiên', N'Đồng Tháp', '1-2-1999', N'Nam', '5124125123125', '0155231231')
INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('KH03', N'Huỳnh Tuấn Anh', N'TP.HCM', '3-4-1999', N'Nữ', '125125125123', '0166123412')
INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('KH04', N'Nguyễn Phúc Hoài Linh', N'Đồng Nai', '5-6-1999', N'Nam', '1254125123', '01681241245')
INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('KH05', N'Nguyễn Đăng Khoa', N'Đồng Nai', '7-8-1999', N'Nữ', '512512512312', '0122125125')
GO

-- Nhap Bang NhanVien
--INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('', N'', N'', , N'', '', '', 0)
INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('NV01', N'Nguyễn Văn A', N'TP.HCM', '9-10-1998', N'Nam', '213213213213', '01681241245', 5000000)
INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('NV02', N'Chu Anh B', N'Đồng Nai', '11-12-2001', N'Nam', '1254125123', '0155231231', 5000000)
INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('NV03', N'Nguyễn Thị C', N'TP.HCM', '1-13-2002', N'Nữ', '125125125123', '0122125125', 5000000)
INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('NV04', N'Nguyễn Đăng D', N'TP.HCM', '2-18-1999', N'Nam', '5124125123125', '0166123412', 5000000)
INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('NV05', N'Huỳnh Tuấn E', N'Đồng Tháp', '3-14-1998', N'Nữ', '512512512312', '0213213213', 5000000)
GO

-- Nhap Bang DangNhap
--INSERT INTO dbo.DangNhap(TenDN, MatKhau, LoaiTaiKhoan) VALUES(N'', N'', N'')
INSERT INTO dbo.DangNhap(TenDN, MatKhau, LoaiTaiKhoan) VALUES(N'Admin', N'1962026656160185351301320480154111117132155', N'Admin')
INSERT INTO dbo.DangNhap(TenDN, MatKhau, LoaiTaiKhoan) VALUES(N'Staff', N'1962026656160185351301320480154111117132155', N'Staff')
GO

-- Nhap Bang HoaDonNhap
--INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('', '', N'', 'mm/dd/yyyy')
INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('HDN01', 'NV01', N'Honda', GETDATE())
INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('HDN02', 'NV02', N'Yamaha', GETDATE())
INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('HDN03', 'NV03', N'BENELLI', GETDATE())
INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('HDN04', 'NV04', N'Exciter', GETDATE())
INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap) VALUES('HDN05', 'NV05', N'Espero', GETDATE())
GO

-- Nhap Bang CTHDNhap
--INSERT INTO dbo.CTHDNhap(Ma, MaXe, SoLuongXe )VALUES('', '', 0, '', 0)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'X01', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'PT02', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'PT03', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'PT04', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'PT05', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'PT06', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'X02', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'X03', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'X04', 10)
INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES('HDN01', 'X05', 10)
GO

-- Nhap Bang HoaDonBan
--INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('', '', '', GETDATE())
INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('HDB01', 'NV01', 'KH01', GETDATE())
INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('HDB02', 'NV02', 'KH02', GETDATE())
INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('HDB03', 'NV03', 'KH03', GETDATE())
INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('HDB04', 'NV04', 'KH04', GETDATE())
INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('HDB05', 'NV05', 'KH05', GETDATE())
GO

-- Nhap Bang CTHDBan
--INSERT INTO dbo.CTHDBan(MaCTHDBan, MaHDBan, Ma, SoLuong )VALUES('', '', '', 0, '', 0)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'X01', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'X01', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB02', 'X03', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB03', 'X04', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB04', 'X05', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB05', 'PT01', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'PT01', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'PT04', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'PT03', 10)
INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES('HDB01', 'PT02', 10)
GO

--Stored Produce
CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.DangNhap WHERE TenDN = @userName AND MatKhau = @passWord
END
GO

CREATE PROC InsertCTHDBan
@MaHDBan VARCHAR(10), @Ma VARCHAR(10), @SoLuong int
AS
BEGIN
    IF EXISTS (SELECT * FROM dbo.CTHDBan WHERE MaHDBan = @MaHDBan AND Ma = @Ma)
    BEGIN
		UPDATE dbo.CTHDBan	SET CTHDBan.SoLuong = CTHDBan.SoLuong + @SoLuong WHERE Ma = @Ma
    END
	ELSE
    BEGIN
		INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong)VALUES(@MaHDBan, @Ma, @SoLuong)
	END
END
GO

CREATE PROC InsertCTHDNhap
@MaHDNhap VARCHAR(10), @Ma VARCHAR(10), @SoLuong int
AS
BEGIN
    IF EXISTS (SELECT * FROM dbo.CTHDNhap WHERE MaHDNhap = @MaHDNhap AND Ma = @Ma)
    BEGIN
		UPDATE dbo.CTHDNhap	SET CTHDNhap.SoLuong = CTHDNhap.SoLuong + @SoLuong WHERE Ma = @Ma
    END
	ELSE
    BEGIN
		INSERT INTO dbo.CTHDNhap(MaHDNhap, Ma, SoLuong)VALUES(@MaHDNhap, @Ma, @SoLuong)
	END
END
GO

--SP cho Report CTHDBan và CTHDNhap
CREATE PROC ViewCTHDBan
@maHDBan VARCHAR(10)
AS
BEGIN
    SELECT TenSP, SoLuong, DonGia FROM dbo.CTHDBan INNER JOIN dbo.SanPham ON CTHDBan.Ma = SanPham.MaSP WHERE MaHDBan = @maHDBan
END
GO

CREATE PROC ViewCTHDNhap
@maHDNhap VARCHAR(10)
AS
BEGIN
    SELECT TenSP, SoLuong, DonGia FROM dbo.CTHDNhap INNER JOIN dbo.SanPham ON CTHDNhap.Ma = SanPham.MaSP WHERE MaHDNhap = @maHDNhap
END
GO

--Trigger
--Trigger Delete Xe và PhuTung -> Delete CTHD
CREATE TRIGGER TriggerDeleteXe
    ON dbo.Xe
    FOR DELETE
AS
	IF EXISTS(SELECT * FROM dbo.CTHDBan INNER JOIN Deleted ON CTHDBan.Ma = Deleted.Ma WHERE CTHDBan.Ma = Deleted.Ma)
	BEGIN
		DELETE CTHDBan FROM dbo.CTHDBan INNER JOIN Deleted ON CTHDBan.Ma = Deleted.Ma WHERE CTHDBan.Ma = Deleted.Ma
	END

	IF EXISTS(SELECT * FROM dbo.CTHDNhap INNER JOIN Deleted ON CTHDNhap.Ma = Deleted.Ma WHERE CTHDNhap.Ma = Deleted.Ma)
	BEGIN
		DELETE CTHDNhap FROM dbo.CTHDNhap INNER JOIN Deleted ON CTHDNhap.Ma = Deleted.Ma WHERE CTHDNhap.Ma = Deleted.Ma
	END
GO

CREATE TRIGGER TriggerDeletePhuTung
    ON dbo.PhuTung
    FOR DELETE
AS
	IF EXISTS(SELECT * FROM dbo.CTHDBan INNER JOIN Deleted ON CTHDBan.Ma = Deleted.Ma WHERE CTHDBan.Ma = Deleted.Ma)
	BEGIN
		DELETE CTHDBan FROM dbo.CTHDBan INNER JOIN Deleted ON CTHDBan.Ma = Deleted.Ma WHERE CTHDBan.Ma = Deleted.Ma
	END

	IF EXISTS(SELECT * FROM dbo.CTHDNhap INNER JOIN Deleted ON CTHDNhap.Ma = Deleted.Ma WHERE CTHDNhap.Ma = Deleted.Ma)
	BEGIN
		DELETE CTHDNhap FROM dbo.CTHDNhap INNER JOIN Deleted ON CTHDNhap.Ma = Deleted.Ma WHERE CTHDNhap.Ma = Deleted.Ma
	END
GO

--Trigger thêm + xóa Xe và PhuTung -> thêm + xóa SanPham
CREATE TRIGGER TriggerIDXe
    ON dbo.Xe
    AFTER INSERT, DELETE
AS
	INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) SELECT Inserted.Ma, Inserted.Ten, Inserted.DonGia FROM Inserted
	DELETE dbo.SanPham FROM Deleted WHERE MaSP = Deleted.Ma
GO

CREATE TRIGGER TriggerIDPhuTung
    ON dbo.PhuTung
    AFTER INSERT, DELETE
AS
	INSERT INTO dbo.SanPham(MaSP, TenSP, DonGia) SELECT Inserted.Ma, Inserted.Ten, Inserted.DonGia FROM Inserted
	DELETE dbo.SanPham FROM Deleted WHERE MaSP = Deleted.Ma
GO

--Trigger Update xe va phu tung vao san pham
CREATE TRIGGER TriggerUpdateXe
	ON dbo.Xe
	FOR UPDATE
AS
	UPDATE SanPham SET SanPham.TenSP = Inserted.Ten, SanPham.DonGia = Inserted.DonGia
	FROM SanPham JOIN Inserted ON SanPham.MaSP = Inserted.Ma
	WHERE SanPham.MaSP = Inserted.Ma
GO

CREATE TRIGGER TriggerUpdatePhuTung
	ON dbo.PhuTung
	FOR UPDATE
AS
	UPDATE SanPham SET SanPham.TenSP = Inserted.Ten, SanPham.DonGia = Inserted.DonGia
	FROM SanPham JOIN Inserted ON SanPham.MaSP = Inserted.Ma
	WHERE SanPham.MaSP = Inserted.Ma
GO

--Function có dấu -> không dấu
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

--Test

