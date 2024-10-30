CREATE DATABASE Library
USE Library

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
    ('SV01', N' Nguyễn Thành Nhân ', '2004-03-23'),
    ('SV02', N'Đặng Thành Nhân', '2004-02-15 '),
    ('SV03', N'Trần Thanh Phước', '2001-07-12'),
    ('SV04', N'Nguyễn Minh Hải', '1993-02-28'),
    ('SV05', N'Trần Thị Hồng Nhung', '1998-07-15');

INSERT INTO Sach 
VALUES
    ('DT01', N'Chủ nghĩa xã hội khoa học', N'Tác giả A', 1000),
    ('DT02', N'Quản lý khách sạn', N'Tác giả B', 2000),
    ('DT03', N'Kinh tế chính trị', N'Tác giả C', 3000),
    ('DT04', N'Pháp luật đại cương', N'Tác giả D', 15000),
    ('DT05', N'Lịch sử Đảng', N'Tác giả E', 20000);

INSERT INTO Muonsach 
VALUES
    ('MU01', 'SV01', '2024-03-25'),
    ('MU02', 'SV02', '2024-01-19'),
    ('MU03', 'SV03', '2024-07-11'),
    ('MU04', 'SV04', '2024-02-28'),
    ('MU05', 'SV05', '2024-07-15');

INSERT INTO CTPM 
VALUES
    ('MU01', 'DT01', '2024-03-23'),
    ('MU02', 'DT02', '2024-01-20'),
    ('MU03', 'DT03', '2024-07-12'),
    ('MU04', 'DT04', '2024-02-28'),
    ('MU05', 'DT05', '2024-07-15');