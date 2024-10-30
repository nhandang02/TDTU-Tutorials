<!-- adminModel.php -->
<?php
require_once 'db.php';

function getListStaffs()
{
    global $conn; // Sử dụng biến $conn được khai báo ở file db.php

    try {
        // Kiểm tra xem kết nối đã được thiết lập thành công chưa
        if (!$conn) {
            return false;
        }

        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT * FROM staff";

        // Chuẩn bị và thực thi câu truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->execute();

        // Lấy danh sách nhân viên từ kết quả truy vấn
        $listStaffs = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Đóng kết nối (không bắt buộc với PDO)
        // $conn = null;

        // Trả về danh sách nhân viên
        return $listStaffs;
    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi khi truy vấn danh sách nhân viên: " . $e->getMessage();
        return false;
    }
}

function getListAttendant()
{
    global $conn; // Sử dụng biến $conn được khai báo ở file db.php

    try {
        // Kiểm tra xem kết nối đã được thiết lập thành công chưa
        if (!$conn) {
            return false;
        }

        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT * FROM staff INNER JOIN account ON staff.username = account.username WHERE account.role = 'attendant'";

        // Chuẩn bị và thực thi câu truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->execute();

        // Lấy danh sách nhân viên từ kết quả truy vấn
        $listStaffs = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Đóng kết nối (không bắt buộc với PDO)
        // $conn = null;

        // Trả về danh sách nhân viên
        return $listStaffs;
    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi khi truy vấn danh sách nhân viên: " . $e->getMessage();
        return false;
    }
}

function getNewStaffID() {
    global $conn;
    try {
        // Query to get the maximum staff ID from the database
        $stmt = $conn->prepare("SELECT MAX(RIGHT(staffID, LENGTH(staffID) - 5)) AS max_id FROM staff");
        $stmt->execute();
        $row = $stmt->fetch(PDO::FETCH_ASSOC);

        // Increment the maximum ID by 1 to generate a new ID
        $maxID = $row['max_id'];
        $newID = 'staff' . str_pad($maxID + 1, 4, '0', STR_PAD_LEFT); // Assuming the ID format is 'staffXXXX'

        return $newID;
    } catch (PDOException $e) {
        // Handle database connection or query errors
        echo "Error: " . $e->getMessage();
        return null;
    }
}

function addStaff($username,$full_name, $phone_number, $address, $email, $role, $salary) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }
        $staffID = getNewStaffID();

        // Prepare the SQL statement to insert data into the staff table
        $sql_staff = "INSERT INTO staff (staffID,username, salary, full_name, phone_number, address, email) VALUES (?,?, ?, ?, ?, ?, ?)";
        $stmt_staff = $conn->prepare($sql_staff);
        $stmt_staff->execute([$staffID,$username, $salary, $full_name, $phone_number, $address, $email]);

        // Retrieve the auto-generated staffID
        

        // Prepare the SQL statement to insert data into the account table
        $password = "1"; // Default password is "1"
        $role = "Nhân viên"; // Set default role
        $sql_account = "INSERT INTO account (username, password, role) VALUES (?, ?, ?)";
        $stmt_account = $conn->prepare($sql_account);
        $stmt_account->execute([$username, $password, $role]);

        // Return true if insertion is successful
        return true;
    } catch (PDOException $e) {
        // Handle any errors
        echo "Error adding new staff: " . $e->getMessage();
        return false;
    }
}

function deleteStaff($staffID) {
    global $conn;

    try {
        // Start a transaction
        $conn->beginTransaction();

        // Delete staff record
        $sqlStaff = "DELETE FROM staff WHERE staffID = ?";
        $stmtStaff = $conn->prepare($sqlStaff);
        $stmtStaff->execute([$staffID]);

        // Commit the transaction
        $conn->commit();

        // Return true if deletion is successful
        return true;
    } catch (PDOException $e) {
        // Rollback the transaction if an error occurs
        $conn->rollBack();

        // Handle any errors
        echo "Error deleting staff: " . $e->getMessage();
        return false;
    }
}


function updateStaff($staffID, $fullname, $phoneNumber, $address, $email, $salary) {
    global $conn;

    try {
        // Prepare the SQL statement to update staff information
        $sql = "UPDATE staff SET full_name = ?, phone_number = ?, address = ?, email = ?, salary = ? WHERE staffID = ?";
        $stmt = $conn->prepare($sql);
        $stmt->execute([$fullname, $phoneNumber, $address, $email, $salary, $staffID]);

        // Return true if update is successful
        return true;
    } catch (PDOException $e) {
        // Handle any errors
        echo "Error updating staff: " . $e->getMessage();
        return false;
    }
}

?>
