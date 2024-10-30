<?php
// Array of countries
$countries = array("Vietnam", "Lao", "Cambodia", "Singapore");

// Get input from POST request
$input = $_POST["query"];

// Filter countries based on input
$suggestions = array_filter($countries, function($country) use ($input) {
    return stripos($country, $input) !== false;
});

// Send back appropriate JSON response
echo json_encode(array_values($suggestions)); // Convert associative array to indexed array
?>
