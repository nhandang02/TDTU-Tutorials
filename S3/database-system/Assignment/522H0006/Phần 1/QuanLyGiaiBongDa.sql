﻿CREATE TABLE NhaTaiTro
(
  MaNTT VARCHAR(10),
  TenNTT NVARCHAR(20),
  DiaChi VARCHAR(20),
  SoDienThoai VARCHAR(20),
  PRIMARY KEY (MaNTT)
);

CREATE TABLE GiaiDau
(
  MaGD VARCHAR(10),
  MuaGiai VARCHAR(10),
  TenGD NVARCHAR(20),
  NgayBatDau DATE,
  NgayKetThuc DATE,
  PRIMARY KEY (MaGD)
);

CREATE TABLE GD_NTT
(
  ThoiGianHopTac NVARCHAR(20),
  SoTienTaiTro FLOAT,
  MaGD VARCHAR(10),
  MaNTT VARCHAR(10),
  PRIMARY KEY (MaGD, MaNTT),
  FOREIGN KEY (MaGD) REFERENCES GiaiDau(MaGD),
  FOREIGN KEY (MaNTT) REFERENCES NhaTaiTro(MaNTT)
);

CREATE TABLE VongDau
(
  MaVongDau VARCHAR(10),
  TenVongDau NVARCHAR(20),
  MaGD VARCHAR(10),
  PRIMARY KEY (MaVongDau),
  FOREIGN KEY (MaGD) REFERENCES GiaiDau(MaGD)
);

CREATE TABLE CauLacBo
(
  MaCLB VARCHAR(10),
  TenCLB NVARCHAR(20),
  MaGD VARCHAR(10),
  PRIMARY KEY (MaCLB),
  FOREIGN KEY (MaGD) REFERENCES GiaiDau(MaGD)
);

CREATE TABLE SanNha
(
  MaSan VARCHAR(10),
  TenSan NVARCHAR(40),
  DiaChi VARCHAR(20),
  SucChua FLOAT,
  MaCLB VARCHAR(10),
  PRIMARY KEY (MaSan),
  FOREIGN KEY (MaCLB) REFERENCES CauLacBo(MaCLB)
);

CREATE TABLE CLB_NTT
(
  ThoiGianHopTac NVARCHAR(20),
  MaCLB VARCHAR(10),
  MaNTT VARCHAR(10),
  PRIMARY KEY (MaCLB, MaNTT),
  FOREIGN KEY (MaCLB) REFERENCES CauLacBo(MaCLB),
  FOREIGN KEY (MaNTT) REFERENCES NhaTaiTro(MaNTT)
);

CREATE TABLE HuanLuyenVien
(
  MaHLV VARCHAR(10),
  TenHLV NVARCHAR(20),
  CuongVi NVARCHAR(20),
  MaCLB VARCHAR(10),
  PRIMARY KEY (MaHLV),
  FOREIGN KEY (MaCLB) REFERENCES CauLacBo(MaCLB)
);

CREATE TABLE CauThu
(
  MaCT VARCHAR(10),
  SoAo INT UNIQUE,
  ViTri NVARCHAR(10),
  MaCLB VARCHAR(10),
  PRIMARY KEY (MaCT),
  FOREIGN KEY (MaCLB) REFERENCES CauLacBo(MaCLB),
);

CREATE TABLE CauThuNoi
(
  QueQuan NVARCHAR(20),
  MaCT VARCHAR(10),
  PRIMARY KEY (MaCT),
  FOREIGN KEY (MaCT) REFERENCES CauThu(MaCT)
);

CREATE TABLE CauThuNgoai
(
  QuocTich NVARCHAR(20),
  MaCT VARCHAR(10),
  PRIMARY KEY (MaCT),
  FOREIGN KEY (MaCT) REFERENCES CauThu(MaCT)
);

CREATE TABLE ThanhTuu
(
  TenThanhTuu NVARCHAR(20),
  NgayDat DATE,
  MuaGiai VARCHAR(10),
  MaCT VARCHAR(10),
  FOREIGN KEY (MaCT) REFERENCES CauThu(MaCT)
);

CREATE TABLE TranDau
(
  MaTran VARCHAR(10),
  NgayDau DATE,
  ThoiGian TIME,
  DiaDiem NVARCHAR(20),
  DoiNha NVARCHAR(20),
  DoiKhach NVARCHAR(20),
  MaDoiNha VARCHAR(10),
  MaVongDau VARCHAR(10),
  PRIMARY KEY (MaTran),
  FOREIGN KEY (MaDoiNha) REFERENCES CauLacBo(MaCLB),
  FOREIGN KEY (MaVongDau) REFERENCES VongDau(MaVongDau)
);

CREATE TABLE CT_TD
(
  BanThang INT,
  TheVang INT,
  TheDo INT,
  MaTran VARCHAR(10),
  MaCT VARCHAR(10),
  PRIMARY KEY (MaTran, MaCT),
  FOREIGN KEY (MaTran) REFERENCES TranDau(MaTran),
  FOREIGN KEY (MaCT) REFERENCES CauThu(MaCT)
);

--INSERT
INSERT INTO NhaTaiTro (MaNTT, TenNTT, DiaChi, SoDienThoai)
VALUES ('NTT01', N'Nhà tài trợ 1', 'Địa chỉ 1', '01234567'),
('NTT02', N'Nhà tài trợ 2', 'Địa chỉ 2', '98765432');

INSERT INTO GiaiDau (MaGD, TenGD, NgayBatDau, NgayKetThuc)
VALUES ('GD01', N'Giải đấu 1', '2023-01-01', '2023-12-31'),
('GD02', N'Giải đấu 2', '2023-03-01', '2023-08-31');

INSERT INTO GD_NTT (ThoiGianHopTac, SoTienTaiTro, MaGD, MaNTT)
VALUES ('1 năm', 100, 'GD01', 'NTT01'),
('2 năm', 200, 'GD02', 'NTT02');

INSERT INTO VongDau (MaVongDau, TenVongDau, MaGD)
VALUES ('VD01', N'Vòng đấu 1', 'GD01'),
('VD02', N'Vòng đấu 2', 'GD02');

INSERT INTO CauLacBo (MaCLB, TenCLB, MaGD)
VALUES ('CLB01', N'Câu lạc bộ 1', 'GD01'),
('CLB02', N'Câu lạc bộ 2', 'GD02');

INSERT INTO SanNha (MaSan, TenSan, DiaChi, SucChua, MaCLB)
VALUES ('SN01', N'Sân nhà 1', 'Địa chỉ 1', 50000, 'CLB01'),
('SN02', N'Sân nhà 2', 'Địa chỉ 2', 100000, 'CLB02');

INSERT INTO CLB_NTT (ThoiGianHopTac, MaCLB, MaNTT)
VALUES ('1 năm', 'CLB01', 'NTT01'),
('2 năm', 'CLB02', 'NTT02');

INSERT INTO HuanLuyenVien (MaHLV, TenHLV, CuongVi, MaCLB)
VALUES ('HLV01', N'Huấn luyện viên 1', N'Chủ tịch', 'CLB01'),
('HLV02', N'Huấn luyện viên 2', N'Giám đốc', 'CLB02');

INSERT INTO CauThu (MaCT, SoAo, ViTri, MaCLB)
VALUES ('CT01', 7, 'Tiền đạo', 'CLB01'),
('CTN01', 11, 'Hậu vệ', 'CLB01');

INSERT INTO CauThuNoi (QueQuan, MaCT)
VALUES (N'Quê quán 1', 'CT01');

INSERT INTO CauThuNgoai (QuocTich, MaCT)
VALUES (N'Quốc tịch 1', 'CTN01');

INSERT INTO ThanhTuu (TenThanhTuu, NgayDat, MuaGiai, MaCT)
VALUES (N'Thành tích 1', '2022-05-20', 'GD01', 'CT01'),
(N'Thành tích 2', '2022-10-12', 'GD02', 'CTN01');

INSERT INTO TranDau (MaTran, NgayDau, ThoiGian, DiaDiem, DoiNha, DoiKhach, MaDoiNha, MaVongDau)
VALUES ('TD01', '2023-02-15', '19:45', N'Địa điểm 1', N'Đội nhà 1', N'Đội khách 1', 'CLB01', 'VD01'),
('TD02', '2023-04-22', '20:00', N'Địa điểm 2', N'Đội nhà 2', N'Đội khách 2', 'CLB02', 'VD02');

INSERT INTO CT_TD (BanThang, TheVang, TheDo, MaTran, MaCT)
VALUES (1, 0, 1, 'TD01', 'CT01'),
(0, 1, 0, 'TD02', 'CTN01');

--FUNCTION
-- Tạo mã cầu thủ nội
CREATE FUNCTION TaoMaCTNoi()
RETURNS varchar(10)
AS
BEGIN
	DECLARE @MaCTHienTai varchar(20)
	DECLARE @STTHienTai INT

	SELECT @MaCTHienTai = MAX(MaCT) FROM CauThu

	IF @MaCTHienTai IS NULL
		SET @MaCTHienTai = 'CT01'
	ELSE
		--Lấy 2 kí tự cuối cùng của mã cầu thủ là STT để chuyển sang dạng số nguyên và cộng thêm 1
		SET  @STTHienTai = CAST(RIGHT(@MaCTHienTai, 2) AS INT) + 1
		--Sau khi đã cập nhật STT hiện tại thì chuyển đổi sang dang kí tự để tạo mã cầu thủ mới
		SET @MaCTHienTai = 'CT' + RIGHT('00' + CAST(@STTHienTai AS VARCHAR(2)), 2)
	RETURN @MaCTHienTai
END
PRINT DBO.TaoMaCTNoi()

-- Tạo mã cầu thủ ngoại
CREATE FUNCTION TaoMaCTNgoai()
RETURNS varchar(10)
AS
BEGIN
	DECLARE @MaCTHienTai varchar(20)
	DECLARE @STTHienTai INT

	SELECT @MaCTHienTai = MAX(MaCT) FROM CauThuNgoai

	IF @MaCTHienTai IS NULL
		SET @MaCTHienTai = 'CTN01'
	ELSE
		-- Lấy 2 kí tự cuối cùng của mã cầu thủ là STT để chuyển sang dạng số nguyên và cộng thêm 1
		SET @STTHienTai = CAST(RIGHT(@MaCTHienTai, 2) AS INT) + 1
		-- Sau khi đã cập nhật STT hiện tại thì chuyển đổi sang dang kí tự để tạo mã cầu thủ mới
		SET @MaCTHienTai = 'CTN' + RIGHT('00' + CAST(@STTHienTai AS VARCHAR(2)), 2)
	RETURN @MaCTHienTai
END
PRINT DBO.TaoMaCTNgoai()

CREATE FUNCTION GetThanhTuu(@MaCT VARCHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT TenThanhTuu, NgayDat, MuaGiai
    FROM ThanhTuu
    WHERE MaCT = @MaCT
);
SELECT * FROM DBO.GetThanhTuu('CT01')

--PROCEDURE
CREATE PROCEDURE ThemCauThu (
    @SoAo INT,
    @ViTri NVARCHAR(10),
    @MaCLB VARCHAR(10),
	@QueQuan NVARCHAR(20),
	@QuocTich NVARCHAR(20)
)
AS
BEGIN
	DECLARE @MaCT VARCHAR(10)
	-- Lấy dữ liệu số áo nhập vào để kiểm tra xem số áo đã tồn tại chưa nếu đạ tồn tại thì in ra lỗi
	IF EXISTS (SELECT 1 FROM CauThu WHERE MaCLB = @MaCLB AND SoAo = @SoAo)
	BEGIN
	  PRINT(N'Số áo đã tồn tại');
	  PRINT(N'Vui lòng nhập số áo khác!')
	  RETURN;  
	END
	-- Tìm câu lạc bộ từ dữ liệu nhập vào nếu không tìm thấy thì in ra lỗi
	IF NOT EXISTS (SELECT 1 FROM CauLacBo WHERE MaCLB = @MaCLB)
	BEGIN
	  PRINT(N'Mã CLB không tồn tại');
	  PRINT(N'Vui lòng nhập mã CLB có trong bảng CLB!')
	  RETURN;  
	END

	IF @QuocTich IS NULL 
	BEGIN
		SET @MaCT = DBO.TaoMaCTNoi()
		INSERT INTO CauThu (MaCT, SoAo, ViTri, MaCLB)
		VALUES (@MaCT, @SoAo, @ViTri, @MaCLB)
    
		INSERT INTO CauThuNoi (MaCT, QueQuan)
		VALUES (@MaCT, @QueQuan)
	END
	ELSE IF @QueQuan IS NULL
	BEGIN
		SET @MaCT = DBO.TaoMaCTNgoai()
		INSERT INTO CauThu (MaCT, SoAo, ViTri, MaCLB)
		VALUES (@MaCT, @SoAo, @ViTri, @MaCLB)
    
		INSERT INTO CauThuNgoai(MaCT, QuocTich)
		VALUES (@MaCT, @QuocTich)
	END
	ELSE
	BEGIN
		PRINT(N'Vui lòng chỉ nhập quốc tịch cho cầu thủ ngoại hoặc quê quán cho cầu thủ nội');
		RETURN;
	END
END;
EXEC ThemCauThu 7, N'Tiền đạo', 'CAHN', N'Hà Nội', NULL

--TRIGGER
CREATE TRIGGER KiemTraSLCauThu
ON CauThu
FOR INSERT
AS
BEGIN
    DECLARE @SoLuongCauThu INT
    DECLARE @SoLuongCauThuNgoai INT

    SELECT @SoLuongCauThu = COUNT(*)
    FROM CauThu

    SELECT @SoLuongCauThuNgoai = COUNT(*)
    FROM CauThuNgoai

    IF @SoLuongCauThu > 30
    BEGIN
        PRINT (N'Số lượng cầu thủ đã đạt tối đa')
        ROLLBACK TRANSACTION
    END
    ELSE IF @SoLuongCauThuNgoai > 5
    BEGIN
        PRINT (N'Số lượng cầu thủ ngoại đã đạt tối đa')
        ROLLBACK TRANSACTION
    END
END;

EXEC ThemCauThu 11, N'Hậu vệ', 'CLB01', NULL,  N'Anh'
EXEC ThemCauThu 72, N'Thủ môn', 'CLB01', NULL, N'Pháp'
EXEC ThemCauThu 27, N'Tiền đạo', 'CLB01', NULL, N'Đức'
EXEC ThemCauThu 17, N'Tiền vệ', 'CLB01', NULL, N'Hàn Quốc'
EXEC ThemCauThu 37, N'Tiền đạo', 'CLB01', NULL, N'Nhật Bản'

--SELECT * FROM CauThuNgoai



