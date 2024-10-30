<?php
require_once('database/product_db.php');

if ($_SERVER['REQUEST_METHOD'] === 'GET') {

    $products = get_products();
    if (count($products) > 0) {
        http_response_code(200); // OK
        echo json_encode($products);
    } else {
        http_response_code(404); // Not Found
        echo json_encode(array("code" => 3, "message" => "No products found"));
    }

} else {
    http_response_code(405); // Method Not Allowed
    echo json_encode(array("code" => 2, "message" => "GET method is required"));
}
?>