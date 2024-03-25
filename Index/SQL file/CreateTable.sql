CREATE TABLE tbl_sach (
	ma_sach INT IDENTITY NOT NULL,
	ten_sach NVARCHAR(50),
	ma_loai_sach INT FOREIGN KEY REFERENCES dbo.tbl_loai_sach(ma_loai_sach),
	tac_gia NVARCHAR(50),
	so_luong INT,
	gia_ban INT,
	PRIMARY KEY(ma_sach)
)

CREATE PROC proc_them_sach
@tenSach NVARCHAR(50), @maLoaiSach INT, @tacGia NVARCHAR(50), @soLuong int, @giaBan int
AS
	BEGIN
		INSERT INTO tbl_sach(ten_sach, ma_loai_sach, tac_gia, so_luong, gia_ban)
		VALUES(@tenSach, @maLoaiSach, @tacGia, @soLuong, @giaBan)
	END

CREATE PROC proc_cap_nhat_sach
@maSach INT, @tenSach NVARCHAR(50), @maLoaiSach INT, @tacGia NVARCHAR(50), @soLuong int, @giaBan int
AS
	BEGIN
		UPDATE tbl_sach
		SET ten_sach = @tenSach, ma_loai_sach = @maLoaiSach,
		tac_gia = @tacGia, so_luong = @soLuong, gia_ban = @giaBan
		WHERE ma_sach = @maSach
	END

CREATE TABLE tbl_loai_sach (
	ma_loai_sach INT PRIMARY KEY NOT NULL IDENTITY,
	ten_loai_sach NVARCHAR(50),
)

CREATE PROC proc_them_loai_sach
@tenLoaiSach NVARCHAR(50)
AS
	BEGIN
		INSERT INTO tbl_loai_sach(ma_loai_sach) VALUES(@tenLoaiSach)
	END

CREATE PROC proc_cap_nhat_loai_sach
@maLoaiSach INT, @tenLoaiSach NVARCHAR(50)
AS
	BEGIN
		UPDATE tbl_loai_sach
		SET ten_loai_sach = @tenLoaiSach
		WHERE ma_loai_sach = @maLoaiSach;
	END

CREATE TABLE tbl_hoa_don (
	ma_hoa_don INT PRIMARY KEY NOT NULL IDENTITY,
	ngay_lap_hoa_don DATE,
	ten_khach_hang NVARCHAR(50),
	sdt_khac_hang INT,
)

CREATE TABLE tbl_phieu_nhap (
	ma_phieu_nhap INT PRIMARY KEY NOT NULL IDENTITY,
	ngay_lap_phieu_nhap DATE,
	ten_nha_cung_cap NVARCHAR(50),
)

CREATE TABLE tbl_chi_tiet_hoa_don (
	ma_hoa_don INT FOREIGN KEY REFERENCES dbo.tbl_hoa_don(ma_hoa_don),
	ma_sach INT FOREIGN KEY REFERENCES dbo.tbl_sach(ma_sach),
	so_luong INT,
	gia_nhap FLOAT,
	PRIMARY KEY(ma_hoa_don, ma_sach),
)

CREATE TABLE tbl_chi_tiet_phieu_nhap (
	ma_phieu_nhap INT FOREIGN KEY REFERENCES dbo.tbl_phieu_nhap(ma_phieu_nhap),
	ma_sach INT FOREIGN KEY REFERENCES dbo.tbl_sach(ma_sach),
	so_luong INT,
	PRIMARY KEY(ma_phieu_nhap, ma_sach),
)

CREATE PROC proc_cap_nhat_hoa_don
@maHoaDon INT, @ngayLapHoaDon DATETIME, @tenKhachHang NVARCHAR(50), @sdtKhachHang VARCHAR(10)
AS
	BEGIN
		UPDATE tbl_hoa_don
		SET ngay_lap_hoa_don = @ngayLapHoaDon, ten_khach_hang = @tenKhachHang, sdt_khach_hang = @sdtKhachHang
		WHERE ma_hoa_don = @maHoaDon
	END

CREATE PROC proc_them_hoa_don
@ngayLapHoaDon DATETIME, @tenKhachHang NVARCHAR(50), @sdtKhachHang VARCHAR(10)
AS
	BEGIN
		INSERT INTO tbl_hoa_don(ngay_lap_hoa_don,ten_khach_hang,sdt_khach_hang)
		VALUES (@ngayLapHoaDon,@tenKhachHang,@sdtKhachHang)
	END

CREATE PROC proc_them_chi_tiet_phieu_nhap
@maPhieuNhap INT, @maSach INT, @soLuong int, @giaNhap FLOAT
AS
	BEGIN
		INSERT INTO tbl_chi_tiet_phieu_nhap VALUES(@maPhieuNhap,@maSach,@soLuong, @giaNhap)
	END

CREATE PROC proc_cap_nhat_chi_tiet_phieu_nhap
@maPhieuNhap INT, @maSach INT, @soLuong int, @giaNhap float
AS
	BEGIN
		UPDATE tbl_chi_tiet_phieu_nhap
		SET so_luong = @soLuong, gia_nhap = @giaNhap
		WHERE ma_phieu_nhap = @maPhieuNhap and ma_sach = @maSach
	END

CREATE PROC proc_cap_nhat_phieu_nhap
@maPhieuNhap INT, @ngayLapPhieuNhap DATETIME, @tenNhaCungCap NVARCHAR(50)
AS
	BEGIN
		UPDATE tbl_PHIEU_NHAP
		SET ngay_lap_phieu_nhap = @ngayLapPhieuNhap, ten_nha_cung_cap = @tenNhaCungCap
		WHERE ma_phieu_nhap = @maPhieuNhap
	END

CREATE PROC proc_them_phieu_nhap
@ngayLapPhieuNhap DATETIME, @tenNhaCungCap NVARCHAR(50)
AS
	BEGIN
		INSERT INTO tbl_phieu_nhap(ngay_lap_phieu_nhap,ten_nha_cung_cap) VALUES(@ngayLapPhieuNhap,@tenNhaCungCap)
	END

CREATE PROC proc_them_chi_tiet_hoa_don
@maHoaDon int, @maSach int, @soLuong INT
AS
	BEGIN
		INSERT INTO tbl_chi_tiet_hoa_don VALUES(@maHoaDon,@maSach,@soLuong)
	END

CREATE PROC proc_cap_nhat_chi_tiet_hoa_don
@maHoaDon int, @maSach int, @soLuong INT
AS
	BEGIN
		UPDATE tbl_chi_tiet_hoa_don
		SET so_luong = @soLuong
		WHERE ma_hoa_don = @maHoaDon AND ma_sach = @maSach
	END

