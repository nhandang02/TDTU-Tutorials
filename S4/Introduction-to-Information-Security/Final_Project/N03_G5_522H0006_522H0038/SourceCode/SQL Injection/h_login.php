<?php
session_start();
include 'connect.php';
function contains_quotes($str)
{
    if (strpos($str, "'") !== false || strpos($str, '"') !== false)
        return true;
    return false;
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST['username'];
    $password = $_POST['password'];
    // if (contains_quotes($username) || contains_quotes($password))
    //    header('Location: login.php?error=2');
    // else {
    //     $sql = "SELECT * FROM user WHERE username = ? AND password = ?";
    //     $stmt = $conn->prepare($sql);
    //     $stmt->bind_param("ss", $username, $password);
    //     $stmt->execute();
    //     $result = $stmt->get_result();

        $sql = "SELECT * FROM user WHERE username = '$username' AND password = '$password'";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            $_SESSION['username'] = $username;
            header('Location: service.php');
            exit;
        } else {
            header('Location: login.php?error=1');
            exit;
        }
    // }
}
