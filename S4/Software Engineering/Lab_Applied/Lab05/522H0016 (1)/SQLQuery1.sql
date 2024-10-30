CREATE DATABASE LibraryDB
USE LibraryDB

CREATE TABLE Docgia (
    Madocgia VARCHAR(5) PRIMARY KEY,
    Hoten NVARCHAR(50),
    Ngaysinh DATE,
);

CREATE TABLE Sach (
    Masach VARCHAR(5) PRIMARY KEY,
    Tensach NVARCHAR(100),
    Tacgia NVARCHAR(50),
    Soluong int
);

CREATE TABLE Muonsach (
    Maphieumuon VARCHAR(5) primary key,
    Madocgia VARCHAR(5),
    Ngaymuon DATE,
    FOREIGN KEY (Madocgia) REFERENCES Docgia(Madocgia),
);

CREATE TABLE CTPM (
    Maphieumuon VARCHAR(5),
    Masach VARCHAR(5),
    Ngaytra DATE,
    PRIMARY KEY (Maphieumuon, Masach),
    FOREIGN KEY (Masach) REFERENCES Sach(Masach),
);


-------------------------------------------------------------------------
INSERT INTO Docgia 
VALUES
    ('SV01', N'Trần Thanh Trâm', '1998-03-23'),
    ('SV02', N'Nguyễn Hồng Linh', '2000-01-20'),
    ('SV03', N'Trần Thanh Phước', '2001-07-12'),
    ('SV04', N'Nguyễn Minh Hải', '1993-02-28'),
    ('SV05', N'Trần Thị Hồng Nhung', '1998-07-15');

INSERT INTO Sach 
VALUES
    ('DT01', N'Quản lý quán ăn', N'Nguyễn Thễ Hữu', 1000),
    ('DT02', N'Quản lý khách sạn', N'Trần Trung Hiếu', 2000),
    ('DT03', N'Quản lý sân bóng đá mini', N'Nguyễn Công Tâm', 3000),
    ('DT04', N'Quản lý shop hoa tươi', N'Đặng Đức Trung', 15000),
    ('DT05', N'Quản lý cửa hàng điện thoại', N'Trịnh Thanh Duy', 20000);

INSERT INTO Muonsach 
VALUES
    ('MU01', 'SV01', '2024-03-23'),
    ('MU02', 'SV02', '2024-01-20'),
    ('MU03', 'SV03', '2024-07-12'),
    ('MU04', 'SV04', '2024-02-28'),
    ('MU05', 'SV05', '2024-07-15');

INSERT INTO CTPM 
VALUES
    ('MU01', 'DT01', '2024-03-23'),
    ('MU02', 'DT02', '2024-01-20'),
    ('MU03', 'DT03', '2024-07-12'),
    ('MU04', 'DT04', '2024-02-28'),
    ('MU05', 'DT05', '2024-07-15');