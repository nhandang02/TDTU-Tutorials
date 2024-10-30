<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Simple Calculator</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
</head>
<body>

<div class="container mt-5">
    <h2 class="mb-4">Simple Calculator</h2>
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <div class="form-group">
            <label for="num1">Number 1:</label>
            <input type="text" class="form-control" id="num1" name="num1" required>
        </div>
        <div class="form-group">
            <label for="num2">Number 2:</label>
            <input type="text" class="form-control" id="num2" name="num2" required>
        </div>
        <div class="form-group">
            <label>Operation:</label><br>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="operation" id="add" value="add" checked>
                <label class="form-check-label" for="add">Addition (+)</label>
            </div>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="operation" id="subtract" value="subtract">
                <label class="form-check-label" for="subtract">Subtraction (-)</label>
            </div>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="operation" id="multiply" value="multiply">
                <label class="form-check-label" for="multiply">Multiplication (*)</label>
            </div>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="operation" id="divide" value="divide">
                <label class="form-check-label" for="divide">Division (/)</label>
            </div>
        </div>
        <button type="submit" class="btn btn-primary">View Result</button>
    </form>

    <?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $num1 = $_POST['num1'];
        $num2 = $_POST['num2'];
        $operation = $_POST['operation'];

        switch ($operation) {
            case 'add':
                $result = $num1 + $num2;
                echo "<p>The result of addition is: $result</p>";
                break;
            case 'subtract':
                $result = $num1 - $num2;
                echo "<p>The result of subtraction is: $result</p>";
                break;
            case 'multiply':
                $result = $num1 * $num2;
                echo "<p>The result of multiplication is: $result</p>";
                break;
            case 'divide':
                if ($num2 == 0) {
                    echo "<p>Error: Division by zero!</p>";
                } else {
                    $result = $num1 / $num2;
                    echo "<p>The result of division is: $result</p>";
                }
                break;
            default:
                echo "<p>Invalid operation selected.</p>";
        }
    }
    ?>
</div>

</body>
</html>
