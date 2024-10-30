<?php
include("db.php");

if ($_SERVER["REQUEST_METHOD"] == "POST") { 
    // Get cookie
    $username = $_COOKIE["username"];

    //////////////////////////////////////////////////////////////////////
    
    // Use the sanitize_input function to sanitize the comment
    // $comment = sanitize_input($_POST['comment']);

    // Do not use sanitize_input function
    $comment = $_POST['comment'];

    //////////////////////////////////////////////////////////////////////

    $stmt = $conn->prepare("INSERT INTO comments (user_name, comment) VALUES (?, ?)");
   
    $stmt->bind_param("ss", $username, $comment);

    
    if ($stmt->execute()) {
        echo "New comment added successfully";
    } else {
        echo "Error: " . $stmt->error;
    }
 
    $stmt->close();
    $conn->close();
    header("Location: index.php");
    exit();
}

// Function to sanitize input data
function sanitize_input($data) {
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data, ENT_QUOTES, 'UTF-8');
    return $data;
}
?>
