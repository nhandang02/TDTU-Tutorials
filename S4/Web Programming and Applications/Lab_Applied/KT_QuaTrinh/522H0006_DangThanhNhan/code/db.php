<?php

//Import PHPMailer classes into the global namespace
//These must be at the top of your script, not inside a function
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
use PHPMailer\PHPMailer\Exception;

//Load Composer's autoloader
//require 'vendor/autoload.php';

define('HOST', '127.0.0.1');
define('USER', 'root');
define('PASS', ''); //123456
define('DB', 'lab08');

function open_database()
{
    $conn = new mysqli(HOST, USER, PASS, DB);
    if ($conn->connect_error) {
        die('Connect error: ' . $conn->connect_error);
    }
    return $conn;
}

function login($user, $pass) {
    $conn = open_database();
    $sql = "SELECT *, IF(lock_until IS NOT NULL AND lock_until > NOW(), 1, 0) AS is_locked FROM account WHERE username = ?";
    $stmt = $conn->prepare($sql);
    if (!$stmt) {
        return ['code' => 1, 'error' => 'Database preparation error: ' . $conn->error];
    }

    $stmt->bind_param('s', $user);
    if (!$stmt->execute()) {
        return ['code' => 1, 'error' => 'Execution error: ' . $stmt->error];
    }

    $result = $stmt->get_result();
    if ($result->num_rows == 0) {
        return ['code' => 1, 'error' => 'User does not exist'];
    }

    $data = $result->fetch_assoc();
    
    if ($data['is_locked']) {
        return ['code' => 3, 'error' => 'Account is locked. Try again later.'];
    }

    if (!password_verify($pass, $data['password'])) {
    
        $new_attempts = $data['failed_attempts'] + 1;
        if ($new_attempts >= 3) {
      
            $lock_time = 'NOW() + INTERVAL 30 SECOND';
            $sql = "UPDATE account SET failed_attempts = ?, lock_until = $lock_time WHERE username = ?";
            $new_attempts = 0;
        } else {
            $sql = "UPDATE account SET failed_attempts = ? WHERE username = ?";
        }

        $stmt = $conn->prepare($sql);
        $stmt->bind_param('is', $new_attempts, $user);
        $stmt->execute();

        return ['code' => 2, 'error' => 'Invalid password'];
    }

    $sql = "UPDATE account SET failed_attempts = 0, lock_until = NULL WHERE username = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('s', $user);
    $stmt->execute();

    if ($data['activated'] == 0) {
        return ['code' => 3, 'error' => 'Account not activated'];
    }
    
    return ['code' => 0, 'data' => $data];
}

function is_email_exist($email)
{
    $sql = "SELECT username FROM account WHERE email = ? "; //AND password = ?
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('s', $email);

    if (!$stmt->execute()) {
        die('Query error: ' . $stmt->error); //Chạy sql thất bại
    }
    $result = $stmt->get_result();
    if ($result->num_rows > 0) {
        return true; //Tồn tại email trong db.
    } else {
        return false;
    }
}

function register($user, $pass, $first, $last, $email)
{

    if (is_email_exist($email)) {
        return array('code' => 1, 'error' => 'Email exists');
    }

    $_SESSION['password'] = $pass;

    $hash = password_hash($pass, PASSWORD_DEFAULT);
    $rand = random_int(0, 1000);
    $token = md5($user . "+" . $rand);

    $sql = "Insert into account(username, firstname, lastname, email, password, activate_token) values(?, ?, ?, ?, ?, ?)"; //AND password = ?
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('ssssss', $user, $first, $last, $email, $hash, $token);

    if (!$stmt->execute()) {
        return array('code' => 2, 'error' => 'Can not execute the command.');
    }
    sendActivationEmail($email, $token);
    return array('code' => 0, 'error' => 'Create account successful.');
}

function activateAccount($email, $token)
{
    $sql = "SELECT * FROM account WHERE email = ? and activate_token = ? and activated = 0"; //AND password = ?
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('ss', $email, $token);

    if (!$stmt->execute()) {
        return array('code' => 1, 'error' => 'Can not execute the command.');
    }
    $result = $stmt->get_result();
    if ($result->num_rows == 0) {
        return array('code' => 2, 'error' => 'Email or token not found');
    }

    $pass = $_SESSION['password'];

    $sql = "UPDATE account SET activated = 1, activate_token = ? WHERE email = ?";
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('ss', $pass, $email);

    if (!$stmt->execute()) {
        return array('code' => 1, 'error' => 'Can not execute the command.');
    }
    return array('code' => 0, 'error' => 'Activate account success');
}

function getProduct()
{
    $sql = "SELECT * FROM product"; //AND password = ?
    $conn = open_database();

    $stmt = $conn->prepare($sql);

    if (!$stmt->execute()) {
        die('Query error: ' . $stmt->error); //Chạy sql thất bại
    }
    $result = $stmt->get_result();

    $data = array();
    while ($d = $result->fetch_assoc()) {
        $data[] = $d;
    }
    return $data;
}

function sendActivationEmail($email, $token)
{

    //Create an instance; passing `true` enables exceptions
    $mail = new PHPMailer(true);

    try {
        //Server settings
        //$mail->SMTPDebug = SMTP::DEBUG_SERVER;                      //Enable verbose debug output
        $mail->isSMTP();                                            //Send using SMTP
        $mail->CharSet = "UTF-8";
        $mail->SMTPSecure = "ssl";
        $mail->Host = 'smtp.gmail.com';                     //Set the SMTP server to send through
        $mail->SMTPAuth = true;                                   //Enable SMTP authentication
        $mail->Username = "";                                 //SMTP username
        $mail->Password = '';                     //SMTP password
        $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;            //Enable implicit TLS encryption
        $mail->Port = 587;                                    //TCP port to connect to; use 587 if you have set `SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS`

        //Recipients
        $mail->setFrom('', 'Admin mailer');
        $mail->addAddress($email, 'User');     //Add a recipient

        // $mail->addAddress('ellen@example.com');               //Name is optional
        // $mail->addReplyTo('info@example.com', 'Information');
        // $mail->addCC('cc@example.com');
        // $mail->addBCC('bcc@example.com');

        //Attachments
        // $mail->addAttachment('/var/tmp/file.tar.gz');         //Add attachments
        // $mail->addAttachment('/tmp/image.jpg', 'new.jpg');    //Optional name

        //Content
        $mail->isHTML(true);                                  //Set email format to HTML
        $mail->Subject = 'Activate your account';
        $mail->Body = "Click  <a href='http://localhost/Lab08_522H0072/activate.php?email=$email&token=$token'>here</a>  to activate your account";
        $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';

        $mail->send();
        return true;
    } catch (Exception $e) {
        return $e;
    }
}

function reset_password($email)
{
    if (!is_email_exist($email)) {
        return array('code' => 1, 'error' => 'Email does not exist');
    }
    $rand = random_int(1000, 2000);
    $token = md5($email . "+" . $rand);
    $sql = 'update reset_token set token = ? where email = ?';
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('ss', $token, $email);
    if (!$stmt->execute()) {
        return array('code' => 2, 'error' => 'Can not execute the command.');
    }
    if ($stmt->affected_rows == 0) {
        $exp = time() + 3600 * 24;

        $sql = 'insert into reset_token values(?,?,?)';
        $stmt = $conn->prepare($sql);
        $stmt->bind_param('ssi', $email, $token, $exp);

        if (!$stmt->execute()) {
            return array('code' => 2, 'error' => 'Can not execute the command.');
        }
        send_reset_email($email, $token);
        return array('code' => 0, 'error' => 'Done successful.');
    }
    return array('code' => 0, 'error' => 'Done successful.');
}

function send_reset_email($email, $token)
{

    //Create an instance; passing `true` enables exceptions
    $mail = new PHPMailer(true);

    try {
        //Server settings
        //$mail->SMTPDebug = SMTP::DEBUG_SERVER;                      //Enable verbose debug output
        $mail->isSMTP();                                            //Send using SMTP
        $mail->CharSet = "UTF-8";
        $mail->Host = 'smtp.gmail.com';                     //Set the SMTP server to send through
        $mail->SMTPAuth = true;                                   //Enable SMTP authentication
        $mail->Username = "";                          //SMTP username
        $mail->Password = '';                     //SMTP password
        $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;            //Enable implicit TLS encryption
        $mail->Port = 587;                                    //TCP port to connect to; use 587 if you have set `SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS`

        //Recipients
        $mail->setFrom('', 'Admin mailer');
        $mail->addAddress($email, 'User');     //Add a recipient

        // $mail->addAddress('ellen@example.com');               //Name is optional
        // $mail->addReplyTo('info@example.com', 'Information');
        // $mail->addCC('cc@example.com');
        // $mail->addBCC('bcc@example.com');

        //Attachments
        // $mail->addAttachment('/var/tmp/file.tar.gz');         //Add attachments
        // $mail->addAttachment('/tmp/image.jpg', 'new.jpg');    //Optional name

        //Content
        $mail->isHTML(true);                                  //Set email format to HTML
        $mail->Subject = 'Reset your password';
        $mail->Body = "Click <a href='http://localhost/Lab08_522H0072/reset_password.php?email=$email&token=$token'>here</a> to reset your password";
        $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';

        $mail->send();
        return true;
    } catch (Exception $e) {
        return false;
    }
}

function change_password($email, $pass)
{
    $_SESSION['password'] = $pass;

    $hash = password_hash($pass, PASSWORD_DEFAULT);
    $rand = random_int(0, 1000);
    $token = md5($email . "+" . $rand);


    $sql = "UPDATE account Set activate_token = ?, password = ? WHERE email = ?";
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('sss', $pass, $hash, $email);

    if (!$stmt->execute()) {
        return array('code' => 2, 'error' => 'Can not execute the command.');
    }
    return array('code' => 0, 'error' => 'Change successfully.');
}

function change_product($pid, $name, $price, $desc)
{

    $sql = "UPDATE product Set name = ?, price = ?, description = ? WHERE id = ?";
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('siss', $name, $price, $desc, $pid);

    if (!$stmt->execute()) {
        return array('code' => 1, 'error' => 'Can not execute the command.');
    }
    return array('code' => 0, 'error' => 'Change successfully.');
}

function add_product($name, $price, $desc, $image)
{

    $img = $image['name'];
    $image_tmp = $image['tmp_name'];
    $target_dir = "images/";
    $target_file = $target_dir . $img;
    if (move_uploaded_file($image_tmp, $target_file)) {
        $sql = "INSERT into product(name, price, description, image) values(?, ?, ?, ?)";
        $conn = open_database();

        $stmt = $conn->prepare($sql);
        $stmt->bind_param('siss', $name, $price, $desc, $img);

        if (!$stmt->execute()) {
            return array('code' => 1, 'error' => 'Can not execute the command.');
        }
        return array('code' => 0, 'error' => 'Add product successfully.');
    }
    return array('code' => 2, 'error' => "An error occurred while uploading the image file.");
}

function delete_product($pid)
{
    $sql = "DELETE FROM product WHERE id = ?";
    $conn = open_database();

    $stmt = $conn->prepare($sql);
    $stmt->bind_param('s', $pid);

    if (!$stmt->execute()) {
        return array('code' => 1, 'error' => 'Can not execute the command.');
    }
    return array('code' => 0, 'error' => 'Delete successfully.');
}
?>