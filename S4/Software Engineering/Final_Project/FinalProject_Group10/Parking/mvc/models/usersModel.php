<!-- adminModel.php -->
<?php
require_once 'db.php';

function getUsers() {
    global $conn; // Sử dụng biến $conn được khai báo ở file db.php

    try {
        // Kiểm tra xem kết nối đã được thiết lập thành công chưa
        if (!$conn) {
            return false;
        }

        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT * FROM users";

        // Chuẩn bị và thực thi câu truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->execute();

        // Lấy danh sách khach hang từ kết quả truy vấn
        $listUsers = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Đóng kết nối (không bắt buộc với PDO)
        // $conn = null;

        // Trả về danh sách nhân viên
        return $listUsers;
    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi khi truy vấn danh sách nhân viên: " . $e->getMessage();
        return false;
    }
}

function getUserInfo($username) {
    global $conn; // Sử dụng biến $conn được khai báo ở file db.php

    try {
        // Kiểm tra xem kết nối đã được thiết lập thành công chưa
        if (!$conn) {
            return false;
        }

        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT * FROM users WHERE username = :username";

        // Chuẩn bị và thực thi câu truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':username', $username);
        $stmt->execute();

        // Lấy thông tin người dùng từ kết quả truy vấn
        $userInfo = $stmt->fetch(PDO::FETCH_ASSOC);

        // Trả về thông tin người dùng
        return $userInfo;
    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi khi truy vấn thông tin người dùng: " . $e->getMessage();
        return false;
    }
}


function addUser($username, $fullname, $phoneNumber, $email, $IDCard, $accountBalance) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Thêm người dùng mới vào cơ sở dữ liệu
        $sql = "INSERT INTO users (username, fullname, phoneNumber, email, IDCard, accountBalance) 
                VALUES (:username, :fullname, :phoneNumber, :email, :IDCard, :accountBalance)";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':username', $username);
        $stmt->bindParam(':fullname', $fullname);
        $stmt->bindParam(':phoneNumber', $phoneNumber);
        $stmt->bindParam(':email', $email);
        $stmt->bindParam(':IDCard', $IDCard);
        $stmt->bindParam(':accountBalance', $accountBalance);
        $stmt->execute();

        return true; // Trả về true nếu thêm người dùng thành công
    } catch (PDOException $e) {
        echo "Lỗi khi thêm người dùng mới: " . $e->getMessage();
        return false;
    }
}

function updateUser($username, $fullname, $phoneNumber, $email, $IDCard, $accountBalance) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Cập nhật thông tin của người dùng trong cơ sở dữ liệu
        $sql = "UPDATE users SET fullname = :fullname, phoneNumber = :phoneNumber, 
                email = :email, IDCard = :IDCard, accountBalance = :accountBalance 
                WHERE username = :username";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':fullname', $fullname);
        $stmt->bindParam(':phoneNumber', $phoneNumber);
        $stmt->bindParam(':email', $email);
        $stmt->bindParam(':IDCard', $IDCard);
        $stmt->bindParam(':accountBalance', $accountBalance);
        $stmt->bindParam(':username', $username);
        $stmt->execute();

        return true; // Trả về true nếu cập nhật người dùng thành công
    } catch (PDOException $e) {
        echo "Lỗi khi cập nhật thông tin người dùng: " . $e->getMessage();
        return false;
    }
}

function deleteUser($userId) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Xóa người dùng khỏi cơ sở dữ liệu
        $sql = "DELETE FROM users WHERE username = :username";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':username', $userId);
        $stmt->execute();

        return true; // Trả về true nếu xóa người dùng thành công
    } catch (PDOException $e) {
        echo "Lỗi khi xóa người dùng: " . $e->getMessage();
        return false;
    }
}

function isCardIDExists($cardID) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT COUNT(*) AS count FROM users WHERE IDCard = :cardID";

        // Chuẩn bị và thực thi câu truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':cardID', $cardID);
        $stmt->execute();

        // Lấy kết quả từ truy vấn
        $result = $stmt->fetch(PDO::FETCH_ASSOC);

        // Kiểm tra xem có tồn tại CardID giống giá trị truyền vào không
        return $result['count'] > 0;

    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi khi kiểm tra CardID tồn tại: " . $e->getMessage();
        return false;
    }
}



?>