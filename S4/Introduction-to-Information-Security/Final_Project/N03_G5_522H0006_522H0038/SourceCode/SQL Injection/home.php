<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Trang chủ</title>
  <!-- Bootstrap CSS -->
  <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
</head>

<body>

  <!-- Thanh menu -->
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <a class="navbar-brand" href="#">Trang chủ</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item active">
          <a class="nav-link" href="service.php">Dịch vụ</a>
        </li>

        <li class="nav-item">
          <a class="nav-link" href="login.php">Đăng nhập</a>
        </li>
      </ul>
    </div>
  </nav>

  <!-- Nội dung trang chủ -->
  <div class="container mt-4">
    <?php
    if (isset($_GET['error'])) echo '<h3> chưa đăng nhập </h3>';
    ?>
    <h2>Xin chào!</h2>
    <p>Đây là trang chủ của chúng tôi.</p>
  </div>

  <!-- Bootstrap JS và các thư viện cần thiết khác -->
  <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>

</html>