<?php
$username = "_nhandawng.15";
$password = "1234567";

//Set cookie 
setcookie("username", $username, time() + (86400 * 30), "/");
setcookie("password", $password, time() + (86400 * 30), "/");

function sanitize_input($data) {
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data, ENT_QUOTES, 'UTF-8');
    return $data;
  }
?>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>XSS DEMO</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .search-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            width: 100%;
            margin: 0 auto;
        }

        .search-container label {
            display: block;
            font-weight: bold;
            margin-bottom: 10px;
        }

        .search-container input[type="text"] {
            width: calc(100% - 40px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            margin-bottom: 20px;
            font-size: 16px;
        }

        .search-container button {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            transition: background-color 0.3s;
        }

        .search-container button:hover {
            background-color: #0056b3;
        }

        .result {
            margin-top: 20px;
            font-size: 18px;
        }
    </style>
</head>

<body>
    <div class="search-container">
        <form method="GET" action="search.php">
            <label for="query">Search:</label>
            <input type="text" id="query" name="query" required>
            <button type="submit">Search</button>
        </form>
        <div class="result">
            <?php
            if (isset($_GET['query'])) {
                $query = $_GET['query'];

                // Sanitize the query parameter
                // $safe_query = sanitize_input($query);

                // Do not use sanitize query
                $safe_query = $query;

                echo "You searched for: <strong>" . $safe_query . "</strong>";
            }
            ?>
        </div>
    </div>
</body>

</html>