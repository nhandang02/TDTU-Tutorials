<?php
require_once ('../models/parkingModel.php');
session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $functionName = $_POST['functionName'];
    if ($functionName == 'add') {
        // Lấy dữ liệu gửi từ form
        $areaID = $_POST['areaID'];
        $cardID = $_POST['cardID'];
        $typeVehicle = $_POST['typeVehicle'];
        $licensePlate = $_POST['licensePlate'];

        // Gọi hàm thêm dữ liệu vào bảng parkingArea từ model
        $result = addParkingArea($areaID, $cardID, $typeVehicle, $licensePlate);

        // Trả về kết quả cho client
        if ($result) {
            echo 'success';
        } else {
            echo 'error';
        }
    }

    if ($functionName == 'finish') {
        $cardID = $_POST['cardID'];
        $result = changeStatus($cardID);
    }

    if ($functionName == 'search') {
        if ($functionName == 'search') {
            // Lấy areaID và typeVehicle từ dữ liệu gửi đi
            $areaID = $_POST['areaID'];
            $vehicleType = $_POST['vehicleType'];
        
            // Gọi hàm từ model để lấy số lượng chỗ trống
            $emptySpaces = getParkingAvailability($areaID, $vehicleType);
        
            // Trả về số lượng chỗ trống cho client
            echo $emptySpaces;
        }
    }

    if ($functionName == 'getPlace') {
        $cardID = $_POST['cardID'];
        $vehicleType = $_POST['vehicleType'];
        $areaID = $_POST['areaID'];

        // Thực hiện đặt trước chỗ trống
        $result = reserveParkingPlace($_SESSION['username'], $cardID, $vehicleType, $areaID);

        // Trả về kết quả cho client
        if ($result) {
            echo 'success';
        } else {
            echo 'error';
        }
    }
}

?>