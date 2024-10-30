<?php 
require_once 'db.php';

function addParkingArea($areaID, $cardID, $typeVehicle, $licensePlate) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        

        // Thêm thông tin mới vào bảng parkingArea
        $sql = "INSERT INTO parkingarea (areaID, IDCard, typeVehicle, status, licensePlate) 
                VALUES (:areaID, :cardID, :typeVehicle, 'on', :licensePlate)";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':areaID', $areaID);
        $stmt->bindParam(':cardID', $cardID);
        $stmt->bindParam(':typeVehicle', $typeVehicle);
        $stmt->bindParam(':licensePlate', $licensePlate);
        $stmt->execute();

        deductionBalance($cardID, $typeVehicle);

        return true; // Trả về true nếu thêm dữ liệu thành công
    } catch (PDOException $e) {
        echo "Lỗi khi thêm dữ liệu vào bảng parkingArea: " . $e->getMessage();
        return false;
    }
}

function deductionBalance($IDCard, $typeVehicle) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Kiểm tra xem IDCard có tồn tại trong bảng users không
        $check_sql = "SELECT * FROM users WHERE IDCard = :IDCard";
        $check_stmt = $conn->prepare($check_sql);
        $check_stmt->bindParam(':IDCard', $IDCard);
        $check_stmt->execute();
        $user = $check_stmt->fetch(PDO::FETCH_ASSOC);

        if (!$user) {
            // Nếu không tìm thấy người dùng, trả về false
            return false;
        }

        $vehicle_type = $typeVehicle;

        // Xác định số tiền sẽ trừ tùy thuộc vào loại phương tiện
        $amount_to_deduct = ($vehicle_type === 'car') ? 2000 : 1000;

        // Trừ số tiền từ tài khoản của người dùng
        $update_sql = "UPDATE users SET accountBalance = accountBalance - :amount WHERE IDCard = :IDCard";
        $update_stmt = $conn->prepare($update_sql);
        $update_stmt->bindParam(':amount', $amount_to_deduct);
        $update_stmt->bindParam(':IDCard', $IDCard);
        $update_stmt->execute();

        return true; // Trả về true nếu trừ tiền thành công
    } catch (PDOException $e) {
        echo "Lỗi khi trừ tiền từ tài khoản: " . $e->getMessage();
        return false;
    }
}


function getParkInfor() {
    global $conn; 

    try {
        if (!$conn) {
            return false;
        }

        $sql = "SELECT * FROM parkingarea where status = 'on'"; 

        $stmt = $conn->prepare($sql);
        $stmt->execute();

        $listVehicle = $stmt->fetchAll(PDO::FETCH_ASSOC);

        return $listVehicle;
    } catch (PDOException $e) {
        echo "Lỗi khi truy vấn danh sách thông báo: " . $e->getMessage();
        return false;
    }
}

function changeStatus($IDCard) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Thực hiện câu truy vấn SQL để cập nhật trạng thái của xe về "off"
        $sql = "UPDATE parkingarea SET status = 'off' WHERE IDCard = :IDCard and status ='on'";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':IDCard', $IDCard);
        $stmt->execute();

        return true; // Trả về true nếu cập nhật thành công
    } catch (PDOException $e) {
        echo "Lỗi khi cập nhật trạng thái của xe: " . $e->getMessage();
        return false;
    }
}

function getParkingAvailability($areaID, $typeVehicle) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Truy vấn cơ sở dữ liệu để đếm số lượng chỗ đỗ xe trống trong khu vực và loại phương tiện cụ thể
        $sql = "SELECT COUNT(*) AS total FROM parkingarea WHERE areaID = :areaID AND typeVehicle = :typeVehicle AND status = 'on'";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':areaID', $areaID);
        $stmt->bindParam(':typeVehicle', $typeVehicle);
        $stmt->execute();

        $result = $stmt->fetch(PDO::FETCH_ASSOC);

        // Trả về số lượng chỗ đỗ xe trống
        return getQuanlity($typeVehicle) - $result['total'] - getBooked($typeVehicle, $areaID);
    } catch (PDOException $e) {
        echo "Lỗi khi lấy số lượng chỗ đỗ xe trống: " . $e->getMessage();
        return false;
    }
}

function getQuanlity($typeVehicle) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Khai báo biến để lưu trữ tên cột cần lấy dựa trên loại phương tiện
        $quantityColumn = ($typeVehicle === 'bike') ? 'bikeQuanlity' : 'carQuanlity';

        // Truy vấn cơ sở dữ liệu để lấy số lượng chỗ đỗ xe trống dựa trên loại phương tiện
        $sql = "SELECT $quantityColumn FROM parkarea";
        $stmt = $conn->prepare($sql);
        $stmt->execute();

        $result = $stmt->fetch(PDO::FETCH_ASSOC);

        // Trả về số lượng chỗ đỗ xe trống
        return $result[$quantityColumn];
    } catch (PDOException $e) {
        echo "Lỗi khi lấy số lượng chỗ đỗ xe trống: " . $e->getMessage();
        return false;
    }
}

function getBooked($typeVehicle, $areaID) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Truy vấn thông tin cấu trúc của bảng
        $stmt = $conn->prepare("SELECT * FROM getplaceinfor WHERE areaID = :areaID AND typeVehicle = :typeVehicle");
        
        // Gắn các tham số định danh
        $stmt->bindParam(':areaID', $areaID);
        $stmt->bindParam(':typeVehicle', $typeVehicle);
        
        // Thực thi câu truy vấn
        $stmt->execute();

        // Đếm số cột trong kết quả trả về
        $columnCount = $stmt->columnCount();

        // Trả về số lượng cột
        return $columnCount;
    
    } catch (PDOException $e) {
        echo "Lỗi khi lấy số lượng chỗ đỗ xe trống: " . $e->getMessage();
        return false;
    }
}

function reserveParkingPlace($username, $cardID, $typeVehicle, $areaID) {
    global $conn;

    try {
        if (!$conn) {
            return false;
        }

        // Thêm thông tin đặt chỗ vào bảng getplaceinfor
        $sql = "INSERT INTO getplaceinfor (username, cardID, typeVehicle, areaID) VALUES (:username, :cardID, :typeVehicle, :areaID)";
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':username', $username);
        $stmt->bindParam(':cardID', $cardID); // Thay thế tham số ':name' bằng ':cardID'
        $stmt->bindParam(':typeVehicle', $typeVehicle);
        $stmt->bindParam(':areaID', $areaID);
        $stmt->execute();

        return true; // Trả về true nếu thêm dữ liệu thành công
    } catch (PDOException $e) {
        echo "Lỗi khi thêm dữ liệu vào bảng getplaceinfor: " . $e->getMessage();
        return false;
    }
}

?>