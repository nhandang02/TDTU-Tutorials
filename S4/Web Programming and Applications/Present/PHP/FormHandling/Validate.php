<h2>PHP Form Validation Example</h2>
<?php //echo htmlspecialchars($_SERVER["PHP_SELF"]);?>
<form method="get" action="">
    Name: <input type="text" name="name">
    <br>
    E-mail: <input type="text" name="email">
    <br>
    Website: <input type="text" name="website">
    <br>
    <input type="submit" name="submit" value="Submit">
</form>

<?php
// define variables and set to empty values
$name = $email = $website = "";

?>

<!--Required fields-->
<?php
 $error = "";
 if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty($_POST["name"])) {
        $error = "name is required";
        echo "<p>Error: $error</p> ";
    }else {
        $username = $_POST["name"];
    }
 }
?>

<?php
echo $username
?>

<!--Sanitizing input data-->
<?php
//function sanitize_input($data) {
//   $data = trim($data);
//   $data = stripslashes($data);
//   $data = htmlspecialchars($data);
//   return $data;
//}
//
//if ($_SERVER["REQUEST_METHOD"] == "POST") {
//   $name = sanitize_input($_POST["name"]);
//}
//?>


<!--Validating specific input types-->
<!--Mail-->
<?php
//if ($_SERVER["REQUEST_METHOD"] == "POST") {
//    if (!filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)) {
//        $error = "Invalid email format";
//        echo "<p>Error: $error</p> ";
//    } else {
//        $email = $_POST["email"];
//    }
//}
//?>

<!--URL-->
<?php
//if ($_SERVER["REQUEST_METHOD"] == "POST") {
//    if (!filter_var($_POST["website"], FILTER_VALIDATE_URL)) {
//        $error = "Invalid URL";
//        echo "<p>Error: $error</p> ";
//    } else {
//        $website = $_POST["website"];
//    }
//}
?>

<?php
//echo "<h2>Your Input:</h2>";
//echo $name;
//echo "<br>";
//echo $email;
//echo "<br>";
//echo $website;
//echo "<br>";
//?>
