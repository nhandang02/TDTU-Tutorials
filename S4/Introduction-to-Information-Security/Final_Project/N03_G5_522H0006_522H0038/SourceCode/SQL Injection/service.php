<?php
session_start();
if (isset($_SESSION['username'])) {
} else
    header('Location: home.php?error=1');
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bảng Bootstrap 4</title>
    <!-- Bootstrap CSS -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
</head>

<body>

    <div class="container mt-5">
        <h2 class="mb-4">Xin chào: <?php if (isset($_SESSION['username'])) echo $_SESSION['username']; ?></h2>
        <h2><a href='logout.php'>Đăng xuất</a></h2>
        <div>
            <form method='get'>
                <input type='text' placeholder="Tìm kiếm..." name='search' />
                <button>Tìm kiếm</button>
            </form>
        </div>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Tên hoa quả</th>
                </tr>
            </thead>
            <tbody>
                <?php
                    include 'connect.php';
                    if(!isset($_GET['search']))
                        $sql = "SELECT id, name FROM fruits";
                    else
                        $sql = "SELECT id, name FROM fruits WHERE name LIKE '%".$_GET['search']."%'";
                    $result = $conn->query($sql);

                    if ($result->num_rows > 0) {
                        while ($row = $result->fetch_assoc()) {
                            echo "<tr>
                                    <td>" . $row["id"] . "</td>
                                    <td>" . $row["name"] . "</td>
                                </tr>";
                        }
                    } else {
                        echo "Không có dữ liệu";
                    }
                    ?>
                    
              
                  <?php
                        // include 'connect.php';
                        // if(!isset($_GET['search'])) {
                        //     $sql = "SELECT id, name FROM fruits";
                        //     $stmt = $conn->prepare($sql);
                        //     $stmt->execute();
                        // } else {
                        //     $sql = "SELECT id, name FROM fruits WHERE name LIKE ?";
                        //     $stmt = $conn->prepare($sql);
                        //     $searchTerm = '%' . $_GET['search'] . '%';
                        //     $stmt->bind_param("s", $searchTerm);
                        //     $stmt->execute();
                        // }
                        // $result = $stmt->get_result();

                        // if ($result->num_rows > 0) {
                        //     while ($row = $result->fetch_assoc()) {
                        //         echo "<tr>
                        //                 <td>" . $row["id"] . "</td>
                        //                 <td>" . $row["name"] . "</td>
                        //             </tr>";
                        //     }
                        // } else {
                        //    echo "Không có dữ liệu";
                        // }
                     ?>


            </tbody>
        </table>
    </div>

    <!-- Bootstrap JS và các thư viện cần thiết khác -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>

</html>