<?php session_start(); ?>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Customer</title>

    <!-- Custom fonts for this template-->
    <link href="../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="../css/sb-admin-2.min.css" rel="stylesheet">

</head>

<body id="page-top">

    <!-- Page Wrapper -->
    <div id="wrapper">

        <!-- Sidebar -->
        <ul class="navbar-nav bg-gradient-primary sidebar sidebar-dark accordion" id="accordionSidebar">

            <!-- Sidebar - Brand -->
            <a class="sidebar-brand d-flex align-items-center justify-content-center" href="users.php">
                <div class="sidebar-brand-icon">
                    <i class="fas fa-user"></i>
                </div>
                <div class="sidebar-brand-text mx-3">Customer</div>
            </a>

            <!-- Divider -->
            <hr class="sidebar-divider my-0">

            <!-- Nav Item - Dashboard -->
            <li class="nav-item">
                <a class="nav-link" href="users.php">
                    <i class="fas fa-fw fa-tachometer-alt"></i>
                    <span>General Information</span></a>
            </li>

            <!-- Divider -->
            <hr class="sidebar-divider">

            <!-- Heading -->
            <div class="sidebar-heading">
                Function
            </div>

            <!-- Nav Item - Employee Management -->
            <li class="nav-item active">
                <a class="nav-link" href="users_search.php">
                    <i class="fas fa-users"></i>
                    <span>Search for vacancies</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="users_getplaces.php">
                    <i class="fas fa-check"></i>
                    <span>Reserve space in advance</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="users_pay.php">
                    <i class="fas fa-dollar-sign" style="margin-right: 10px;"></i>
                    <span>Recharge</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="users_information.php">
                    <i class="fas fa-id-card"></i>
                    <span>Personal information</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="users_notice.php">
                    <i class="fas fa-comments"></i>
                    <span>Notification</span>
                </a>
            </li>

            <li class="nav-item">
                <a class="nav-link" href="users_report.php">
                    <i class="fas fa-exclamation-circle"></i>
                    <span>Report</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class="sidebar-divider">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class="text-center d-none d-md-inline">
                <button class="rounded-circle border-0" id="sidebarToggle"></button>
            </div>

        </ul>
        <!-- End of Sidebar -->

        <!-- Content Wrapper -->
        <div id="content-wrapper" class="d-flex flex-column">

            <!-- Main Content -->
            <div id="content">

                <!-- Topbar -->
                <nav class="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">

                    <!-- Sidebar Toggle (Topbar) -->
                    <button id="sidebarToggleTop" class="btn btn-link d-md-none rounded-circle mr-3">
                        <i class="fa fa-bars"></i>
                    </button>

                    <!-- Topbar Navbar -->
                    <ul class="navbar-nav ml-auto">

                        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                        <li class="nav-item dropdown no-arrow d-sm-none">
                            <a class="nav-link dropdown-toggle" href="#" id="searchDropdown" role="button"
                                data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <i class="fas fa-search fa-fw"></i>
                            </a>
                            <!-- Dropdown - Messages -->
                            <div class="dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"
                                aria-labelledby="searchDropdown">
                                <form class="form-inline mr-auto w-100 navbar-search">
                                    <div class="input-group">
                                        <input type="text" class="form-control bg-light border-0 small"
                                            placeholder="Search for..." aria-label="Search"
                                            aria-describedby="basic-addon2">
                                        <div class="input-group-append">
                                            <button class="btn btn-primary" type="button">
                                                <i class="fas fa-search fa-sm"></i>
                                            </button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </li>

                        <!-- Nav Item - User Information -->
                        <li class="nav-item dropdown no-arrow">
                            <a class="nav-link dropdown-toggle" href="#" id="userDropdown" role="button"
                                data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <span
                                    class="mr-2 d-none d-lg-inline text-gray-600 small"><?php echo $_SESSION['username']; ?></span>
                            </a>
                            <!-- Dropdown - User Information -->
                            <div class="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                                aria-labelledby="userDropdown">
                                <a class="dropdown-item" href="#">
                                    <i class="fas fa-cogs fa-sm fa-fw mr-2 text-gray-400"></i>
                                    Đổi mật khẩu
                                </a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#" data-toggle="modal" data-target="#logoutModal">
                                    <i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                                    Đăng xuất
                                </a>
                            </div>
                        </li>
                    </ul>

                </nav>
                <!-- End of Topbar -->

                <!-- Begin Page Content -->
                <div class="container-fluid">

                    <!-- Page Heading -->
                    <div class="d-sm-flex align-items-center justify-content-between mb-4">
                        <h1 class="h3 mb-0 text-gray-800">Search for vacancies</h1>
                    </div>

                    <!-- Search available space -->
                    <div class="card mb-4 shadow h-100 py-2">
                        <div class="card-header font-weight-bold text-primary">
                            Search for vacancies
                        </div>
                        <div class="card-body">
                            <!-- Form for selecting vehicle type and area -->
                            <form id="searchForm">
                                <div class="form-row">
                                    <div class="col-md-4 mb-3">
                                        <label for="vehicleType">Type Vehicle</label>
                                        <select class="custom-select" id="vehicleType" required>
                                            <option value="">Choose type...</option>
                                            <option value="car">Car</option>
                                            <option value="motorbike">Motorbike</option>
                                        </select>
                                    </div>
                                    <div class="col-md-4 mb-3">
                                        <label for="area">Area</label>
                                        <select class="custom-select" id="area" required>
                                            <option value="">Choose Area...</option>
                                            <option value="A">Area A</option>
                                            <option value="B">Area B</option>
                                            <option value="C">Area C</option>
                                        </select>
                                    </div>
                                    <div class="col-md-4 mb-3">
                                        <label for="searchButton" class="invisible">Search</label>
                                        <button class="btn btn-primary btn-block" type="submit" id="searchButton">Search</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>

                    <!-- Display search results -->
                    <div class="card shadow h-100 py-2">
                        <div class="card-header font-weight-bold text-primary">
                        Search Results
                        </div>
                        <div class="card-body">
                            <div id="searchResults">
                                <!-- Search results will be dynamically added here -->
                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->

            <!-- Footer -->
            <footer class="sticky-footer bg-white">
                <div class="container my-auto">
                    <div class="text-center my-auto">
                        <span>Copyright © Parking</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->

    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
        <i class="fas fa-angle-up"></i>
    </a>

    <!-- Logout Modal-->
    <div class="modal fade" id="logoutModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel"
        aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Ready to Leave?</h5>
                    <button class="close" type="button" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">×</span>
                    </button>
                </div>
                <div class="modal-body">Select "Logout" below if you are ready to end your current session.</div>
                <div class="modal-footer">
                    <button class="btn btn-secondary" type="button" data-dismiss="modal">Cancel</button>
                    <a class="btn btn-primary" href="../login.php">Logout</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="../vendor/jquery/jquery.min.js"></script>
    <script src="../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="../vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="../js/sb-admin-2.min.js"></script>

    <!-- script -->
    <script src="../js/pages/users.js"></script>

    <script>
        // File: users.js
        $(document).ready(function () {
            // Sự kiện khi form được submit
            $('#searchForm').submit(function (event) {
                event.preventDefault(); // Ngăn chặn form gửi thông tin một cách thông thường

                // Lấy dữ liệu từ các trường input
                var vehicleType = $('#vehicleType').val();
                var areaID = $('#area').val();

                // Gửi yêu cầu AJAX đến server để tìm kiếm chỗ trống
                $.ajax({
                    type: 'POST',
                    url: '../../controllers/parkingController1.php', // Đường dẫn đến file xử lý
                    data: {
                        functionName: 'search',
                        vehicleType: vehicleType,
                        areaID: areaID
                    },
                    success: function (response) {
                        // Hiển thị kết quả tìm kiếm trên trang web
                        $('#searchResults').html('<p>Number of vacancies: ' + response + '</p>');
                    },
                    error: function (xhr, status, error) {
                        console.error(error); // Hiển thị lỗi (nếu có) trong trường hợp yêu cầu không thành công
                    }
                });
            });
        });

    </script>

</body>

</html>