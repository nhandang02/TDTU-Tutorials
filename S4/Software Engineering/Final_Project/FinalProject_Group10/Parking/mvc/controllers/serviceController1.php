<?php
require_once ('../models/serviceModel.php');

// Thêm dịch vụ
if (isset($_POST['saveService'])) {
    $serviceName = $_POST['serviceName'];
    $serviceDescription = $_POST['serviceDescription'];

    // Gọi hàm trong controller để thêm dịch vụ
    $result = addService($servername, $serviceDescription);
    return $result;
}

// Xóa dịch vụ
if (isset($_POST['deleteService'])) {
    $serviceId = $_POST['deleteService'];

    $result = deleteService($serviceId);
    return $result;
}

// Sửa dịch vụ
if (isset($_POST['updateService'])) {
    $serviceId = $_POST['serviceId'];
    $serviceName = $_POST['serviceName'];
    $serviceDescription = $_POST['serviceDescription'];

    // Gọi hàm trong controller để cập nhật thông tin dịch vụ
    $result = updateService($serviceId,$servername, $serviceDescription);
    return $result;
}

?>