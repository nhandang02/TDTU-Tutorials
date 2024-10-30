-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 11, 2024 lúc 03:35 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `parking`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `account`
--

CREATE TABLE `account` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `account`
--

INSERT INTO `account` (`username`, `password`, `role`) VALUES
('accountant1', 'password', 'accountant'),
('admin1', 'password', 'admin'),
('attendant1', 'password', 'attendant'),
('M60-132697@internet', '1', 'Nhân viên'),
('user1', 'password', 'user'),
('user11', '1', 'user');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `equipment`
--

CREATE TABLE `equipment` (
  `equipmentID` int(11) NOT NULL,
  `equipmentName` varchar(100) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `adder` varchar(50) DEFAULT 'admin1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `equipment`
--

INSERT INTO `equipment` (`equipmentID`, `equipmentName`, `status`, `adder`) VALUES
(1, 'Security Camera 1', 'Active', 'admin1'),
(2, 'Barrier Gate 2', 'Inactive', 'admin1'),
(3, 'Ticket Machine 3', 'Active', 'admin1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `financial_transactions`
--

CREATE TABLE `financial_transactions` (
  `transaction_id` int(11) NOT NULL,
  `reason` varchar(255) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `note` text DEFAULT NULL,
  `adder` varchar(50) DEFAULT 'admin1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `financial_transactions`
--

INSERT INTO `financial_transactions` (`transaction_id`, `reason`, `amount`, `note`, `adder`) VALUES
(1, 'Mua vật liệu xây dựng', 1500.00, 'Thanh toán cho nhà cung cấp A', 'admin1'),
(2, 'Tiền lương nhân viên', 5000.00, 'Chi trả lương cho tháng 5', 'admin1'),
(3, 'Thuê xe vận chuyển', 800.00, 'Thanh toán dịch vụ vận chuyển hàng hóa', 'admin1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `getplaceinfor`
--

CREATE TABLE `getplaceinfor` (
  `username` varchar(50) DEFAULT NULL,
  `cardID` varchar(255) DEFAULT NULL,
  `typeVehicle` varchar(50) DEFAULT NULL,
  `areaID` varchar(100) DEFAULT NULL,
  `time` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `getplaceinfor`
--

INSERT INTO `getplaceinfor` (`username`, `cardID`, `typeVehicle`, `areaID`, `time`) VALUES
('user1', 'John Doe', 'car', 'A', '2024-05-10 18:24:06'),
('user2', 'Jane Smith', 'car', 'A', '2024-05-10 18:24:06'),
('user3', 'Alice Johnson', 'car', 'A', '2024-05-10 18:24:06');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `notice`
--

CREATE TABLE `notice` (
  `noticeID` int(11) NOT NULL,
  `typeNotice` varchar(50) DEFAULT NULL,
  `target` varchar(50) DEFAULT NULL,
  `content` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `notice`
--

INSERT INTO `notice` (`noticeID`, `typeNotice`, `target`, `content`) VALUES
(1, 'General', 'user1', 'Reminder: Parking fees are due by end of month.'),
(2, 'Urgent', 'user2', 'Your parking reservation for tomorrow has been confirmed.'),
(3, 'General', 'attendant1', 'Please update your contact information.');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `parkarea`
--

CREATE TABLE `parkarea` (
  `areaID` varchar(50) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `bikeQuanlity` int(11) DEFAULT NULL,
  `carQuanlity` int(11) DEFAULT 50
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `parkarea`
--

INSERT INTO `parkarea` (`areaID`, `name`, `bikeQuanlity`, `carQuanlity`) VALUES
('A', 'Parking Lot A', 100, 50),
('B', 'Parking Lot B', 50, 50),
('C', 'Parking Lot C', 75, 50);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `parkingarea`
--

CREATE TABLE `parkingarea` (
  `areaID` varchar(50) DEFAULT NULL,
  `IDCard` varchar(20) DEFAULT NULL,
  `typeVehicle` varchar(50) DEFAULT NULL,
  `status` varchar(10) DEFAULT 'on',
  `licensePlate` varchar(20) DEFAULT '47AB-49018',
  `time` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `parkingarea`
--

INSERT INTO `parkingarea` (`areaID`, `IDCard`, `typeVehicle`, `status`, `licensePlate`, `time`) VALUES
('A', '123456789', 'motorbike', 'on', '47AB-49018', '2024-05-10 18:24:25'),
('B', '987654321', 'car', 'on', '47AB-49018', '2024-05-10 18:24:25'),
('A', '111', 'motorbike', 'on', '47AB-49018', '2024-05-10 18:24:25'),
('A', '111111111111111', 'motorbike', 'on', '47AB-49018', '2024-05-10 18:24:25'),
('A', '111', 'motorbike', 'on', '47AB-49018', '2024-05-10 18:24:25'),
('A', '111', 'motorbike', 'on', '47AB', '2024-05-10 18:24:25'),
('A', 'a', 'Xe máy', 'on', 'a', '2024-05-10 18:24:25'),
('A', '1111', 'motorbike', 'on', '47AB', '2024-05-10 18:24:25'),
('A', 'Hafo ngu', 'motorbike', 'on', '47AB', '2024-05-10 18:24:25'),
('A', '4953', 'Xe máy', 'on', '4953', '2024-05-10 18:24:25'),
('A', '123456789', 'motorbike', 'on', '47AB', '2024-05-10 18:24:25'),
('A', '123456789', 'car', 'on', '47AB', '2024-05-10 18:24:25'),
('A', '', 'motorbike', 'off', '', '2024-05-10 18:24:25');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `payment`
--

CREATE TABLE `payment` (
  `paymentID` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `payment`
--

INSERT INTO `payment` (`paymentID`, `username`, `amount`, `time`, `status`) VALUES
(1, 'user1', 50.00, '2024-05-07 09:30:00', 'Completed'),
(2, 'user2', 20.00, '2024-05-07 11:00:00', 'Completed'),
(3, 'user3', 30.00, '2024-05-07 12:15:00', 'Completed'),
(4, 'user1', 100000.00, '2024-05-10 01:27:31', 'Thành công'),
(5, 'user1', 0.00, '2024-05-10 01:28:25', 'Completed'),
(6, 'user1', 100000.00, '2024-05-10 01:45:52', 'Completed'),
(7, 'user1', 50000.00, '2024-05-10 04:10:41', 'Completed'),
(8, 'user1', 0.00, '2024-05-10 05:20:46', 'Pending'),
(9, 'user1', 0.00, '2024-05-10 05:21:49', 'Pending'),
(10, 'user1', 12123.00, '2024-05-10 05:21:53', 'Pending'),
(11, 'user1', -111.00, '2024-05-10 05:23:36', 'Completed'),
(12, 'user1', 100000.00, '2024-05-10 05:41:52', 'Pending');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `report`
--

CREATE TABLE `report` (
  `reportID` int(11) NOT NULL,
  `typeReport` varchar(50) DEFAULT NULL,
  `sender` varchar(50) DEFAULT NULL,
  `content` text DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `report`
--

INSERT INTO `report` (`reportID`, `typeReport`, `sender`, `content`, `status`) VALUES
(1, 'Issue', 'user1', 'The parking gate is not functioning properly.', 'Solved'),
(2, 'Complaint', 'user2', 'Unauthorized vehicle parked in my designated spot.', 'Solved'),
(3, 'Feedback', 'user3', 'The parking attendants are very helpful.', 'Solved');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `service1`
--

CREATE TABLE `service1` (
  `serviceID` varchar(50) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `adder` varchar(50) DEFAULT 'admin1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `service1`
--

INSERT INTO `service1` (`serviceID`, `name`, `description`, `adder`) VALUES
('', 'localhost', 'aaaaaaaaa', 'admin1'),
('2', 'localhost', 'Regular maintenance of equipment and faciliti\\a', 'admin1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `shift`
--

CREATE TABLE `shift` (
  `day` varchar(20) NOT NULL,
  `morning` varchar(50) DEFAULT NULL,
  `afternoon` varchar(50) DEFAULT NULL,
  `evening` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `shift`
--

INSERT INTO `shift` (`day`, `morning`, `afternoon`, `evening`) VALUES
('1.Monday', 'staff1', 'staff2', 'staff3'),
('2.Tuesday', 'staff3', 'staff1', 'staff2'),
('3.Wednesday', 'staff2', 'staff3', 'staff1'),
('4.Thursday', 'staff1', 'staff2', 'staff3'),
('5.Friday', 'staff3', 'staff1', 'staff2'),
('6.Saturday', 'staff2', 'staff3', 'staff1'),
('7.Sunday', 'staff1', 'staff2', 'staff3');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `staff`
--

CREATE TABLE `staff` (
  `staffID` varchar(50) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `salary` decimal(10,2) DEFAULT NULL,
  `full_name` varchar(255) NOT NULL,
  `phone_number` varchar(20) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `staff`
--

INSERT INTO `staff` (`staffID`, `username`, `salary`, `full_name`, `phone_number`, `address`, `email`) VALUES
('staff1', 'M60-132697@internet', 20000000.00, 'Nhan Ngu', '0358948134', 'Ho Chi Minh', 'phucpham.1803@gmail.co'),
('staff2', 'user5', 1800.00, '', NULL, NULL, NULL),
('staff3', 'user6', 2200.00, '', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `username` varchar(50) NOT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `phonenumber` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `IDCard` varchar(20) DEFAULT NULL,
  `accountBalance` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`username`, `fullname`, `phonenumber`, `email`, `IDCard`, `accountBalance`) VALUES
('522H0068', 'Phuc Pham', '0358948134', 'phucpham.1803@gmail.com', '1111111111', 0.00),
('user1', 'John Doe', '123456789', 'john@example.com', '123456789', 147334.00),
('user2', 'Jane Smith', '987654321', 'jane@example.com', '987654321', 500.00),
('user3', 'Alice Johnson', '555666777', 'alice@example.com', '555666777', 800.00);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `unique_username` (`username`);

--
-- Chỉ mục cho bảng `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`equipmentID`);

--
-- Chỉ mục cho bảng `financial_transactions`
--
ALTER TABLE `financial_transactions`
  ADD PRIMARY KEY (`transaction_id`);

--
-- Chỉ mục cho bảng `getplaceinfor`
--
ALTER TABLE `getplaceinfor`
  ADD KEY `username` (`username`);

--
-- Chỉ mục cho bảng `notice`
--
ALTER TABLE `notice`
  ADD PRIMARY KEY (`noticeID`);

--
-- Chỉ mục cho bảng `parkarea`
--
ALTER TABLE `parkarea`
  ADD PRIMARY KEY (`areaID`);

--
-- Chỉ mục cho bảng `parkingarea`
--
ALTER TABLE `parkingarea`
  ADD KEY `areaID` (`areaID`);

--
-- Chỉ mục cho bảng `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`paymentID`),
  ADD KEY `username` (`username`);

--
-- Chỉ mục cho bảng `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`reportID`),
  ADD KEY `fk_report_sender` (`sender`);

--
-- Chỉ mục cho bảng `service1`
--
ALTER TABLE `service1`
  ADD PRIMARY KEY (`serviceID`);

--
-- Chỉ mục cho bảng `shift`
--
ALTER TABLE `shift`
  ADD PRIMARY KEY (`day`);

--
-- Chỉ mục cho bảng `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staffID`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `equipment`
--
ALTER TABLE `equipment`
  MODIFY `equipmentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `financial_transactions`
--
ALTER TABLE `financial_transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `notice`
--
ALTER TABLE `notice`
  MODIFY `noticeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `payment`
--
ALTER TABLE `payment`
  MODIFY `paymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT cho bảng `report`
--
ALTER TABLE `report`
  MODIFY `reportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `getplaceinfor`
--
ALTER TABLE `getplaceinfor`
  ADD CONSTRAINT `getplaceinfor_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`);

--
-- Các ràng buộc cho bảng `parkingarea`
--
ALTER TABLE `parkingarea`
  ADD CONSTRAINT `parkingarea_ibfk_1` FOREIGN KEY (`areaID`) REFERENCES `parkarea` (`areaID`);

--
-- Các ràng buộc cho bảng `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
