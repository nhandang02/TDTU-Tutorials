<form action="" method="post">
    <label for="FullName">Full Name:</label>
    <input type="text" name="FullName" id="FullName"><br>
    <label for="PhoneNumber">Phone Number:</label>
    <input type="text" name="PhoneNumber" id="PhoneNumber"><br>
    <input type="submit" value="Submit">
</form>

<?php
    $FullName = $_POST["FullName"];
    echo "Your full name is: " . $FullName;
    $PhoneNumber = $_POST["PhoneNumber"];
    echo "Your phone number is: " . $PhoneNumber;
//?>

<?php
//if (isset($_POST["FullName"])) {
//    $FullName = $_POST["FullName"];
//    echo "Your full name is: " . $FullName;
//    echo "<br>";
//} else {
//    echo "The full name is empty";
//}
//if (isset($_POST["PhoneNumber"])) {
//    $PhoneNumber = $_POST["PhoneNumber"];
//    echo "Your phone number is: " . $PhoneNumber;
//} else {
//    echo "The phone number is empty";
//}
//?>
