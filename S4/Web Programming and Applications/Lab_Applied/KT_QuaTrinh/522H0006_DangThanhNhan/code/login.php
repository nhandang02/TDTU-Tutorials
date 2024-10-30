<?php
session_start();

require_once('db.php');

$response = array();

if (isset($_POST['user']) && isset($_POST['pass'])) {
    $user = $_POST['user'];
    $pass = $_POST['pass'];

    if (empty($user)) {
        $response['error'] = 'Please enter your username';
    } elseif (empty($pass)) {
        $response['error'] = 'Please enter your password';
    } elseif (strlen($pass) < 6) {
        $response['error'] = 'Password must have at least 6 characters';
    } else {
        $result = login($user, $pass);

        if ($result['code'] == 0) {
            $data = $result['data'];
            $_SESSION['user'] = $user;
            $_SESSION['name'] = $data['firstname'] . " " . $data['lastname'];

            $response['success'] = true;
        } else {
            $response['error'] = $result['error'];
        }
    }
} else {
    $response['error'] = 'Invalid request';
}
echo json_encode($response);
?>
