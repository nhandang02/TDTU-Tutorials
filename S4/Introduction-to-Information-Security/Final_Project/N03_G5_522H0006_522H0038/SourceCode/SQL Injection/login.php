<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Đăng nhập</title>
<!-- Bootstrap CSS -->
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>

<div class="container mt-5">
    <div class="row justify-content-center">
        <div class="col-md-6">
            <div class="card">
                <div class="card-header">Đăng nhập</div>
                <?php 
                if(isset($_GET['error']) && $_GET['error'] == 1) echo '<h3> tài khoản mật khẩu không chính xác </h3>';
                if(isset($_GET['error']) && $_GET['error'] == 2) echo '<h3> không được chứa ký tự cấm </h3>';
                ?>
                <div class="card-body">
                    <form action='h_login.php' method='post'>
                        <div class="form-group">
                            <label for="email">Username</label>
                            <input type="text" name='username' class="form-control" id="email" placeholder="Nhập username">
                        </div>
                        <div class="form-group">
                            <label for="password">Mật khẩu</label>
                            <input type="text" name='password' class="form-control" id="password" placeholder="Nhập mật khẩu">
                        </div>
                        <button type="submit" class="btn btn-primary">Đăng nhập</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Bootstrap JS và các thư viện cần thiết khác -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>