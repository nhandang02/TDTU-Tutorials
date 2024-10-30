<?php
    session_start();
    if (!isset($_SESSION['user'])) {
        header('Location: login.php');
        exit();
    }
    require_once('db.php');


    if(isset($_POST['action'])&&isset($_POST['product-id'])){
        $action = $_POST['action'];
        $pid = $_POST['product-id'];

        if($action == "delete-product"){
            $result = delete_product($pid);
            $error = $result['error'];
            echo "<script>alert('$error')</script>";
        }
        elseif($action == "update-product"){
            if(isset($_POST['name'])&&isset($_POST['price'])&&isset($_POST['desc']))
            {
                $name = $_POST['name'];
                $price = $_POST['price'];
                $desc = $_POST['desc'];
                $result = change_product($pid, $name, $price, $desc);
                $error = $result['error'];
                echo "<script>alert('$error')</script>";
            }
            else{
                echo "<script>alert('')</script>";
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Trang chủ - Danh sách sản phẩm</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css" integrity="sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        td {
            vertical-align: middle;
        }
        img {
            max-height: 100px;
        }
    </style>
</head>
<body>

<div class="container">
    <div class="row justify-content-center">
        <div class="col col-md-10">
            <h3 class="my-4 text-center">Product List</h3>
            <div class="d-flex justify-content-between">
                <a class="btn btn-sm btn-secondary mb-4" href="add_product.php">Add Product</a>
                <span style="" class="h3 text-success">Hello <?= $_SESSION['name']?></span>
                <a href="logout.php">Logout</a>
            </div>
            <table class="table-bordered table table-hover text-center">
                <tr>
                    <th>Image</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Description</th>
                    <th>Actions</th>
                </tr>
                <?php
                    $product = getProduct();
                    foreach($product as $p){
                        ?>
                            <tr>
                                <td class="align-middle"><img src="images/<?= $p['image'] ?>"></td>
                                <td class="align-middle"><?= $p['name'] ?></td>
                                <td class="align-middle"><?= number_format($p['price']) ?> VND</td>
                                <td class="align-middle"><?= $p['description'] ?></td>
                                <td class="align-middle">
                                    <button onclick="updateP('<?= $p['id'] ?>', '<?= $p['name'] ?>', '<?= $p['price'] ?>', '<?= $p['description'] ?>')" class="btn btn-sm btn-primary mr-1 edit-btn"><i class="fas fa-pen"></i></button>
                                    <button onclick="deleteP('<?= $p['id'] ?>', '<?= $p['name'] ?>')" class="btn btn-sm btn-danger delete-btn"><i class="fas fa-trash-alt"></i></button>
                                </td>
                            </tr>
                        <?php
                    }
                ?>
            </table>
            <p class="text-right">Total products: <strong id="count-product"><?= count($product) ?></strong></p>
        </div>
    </div>
</div>

    <!-- Delete Confirm Modal -->
    <div id="deleteModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <form action="" method="post">
                <div class="modal-content">
                    <div class="modal-header">
                        <hp class="modal-title">Delete a Product</hp>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body">
                        <p>Are you sure you want to delete <strong id="delete-product">iPhone XS MAX</strong> ?</p>
                    </div>
                    <div class="modal-footer">
                        <input type="hidden" name="product-id" value="" id="delete-input">
                        <input type="hidden" name="action" value="delete-product">
                        <button type="button" class="btn btn-sm btn-secondary" data-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-sm btn-danger">Delete</button>
                    </div>

                </div>
            </form>
        </div>
    </div>


    <!-- Edit Confirm Modal -->
    <div id="editModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <hp class="modal-title">Update product <strong id="edit-product">iPhone XS MAX</strong></hp>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <form method="post">
                    <div class="modal-body">
                            <div class="form-group">
                                <label for="name">Product Name</label>
                                <input name="name" id="name" type="text" class="form-control">
                            </div>
                            <div class="form-group">
                                <label for="price">Price</label>
                                <input name="price" id="price" type="number" class="form-control">
                            </div>
                            <div class="form-group">
                                <label for="desc">Description</label>
                                <input name="desc" id="desc" type="text" class="form-control">
                            </div>
                            <input type="hidden" name="product-id" value="" id="update-input">
                            <input type="hidden" name="action" value="update-product">
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-sm btn-secondary" data-dismiss="modal">Close</button>
                        <button type="submit" class="btn btn-sm btn-success">Save</button>
                    </div>
                </form>
            </div>
    
        </div>
    </div>

    <script>

        $(document).ready(function () {

            // show delete confirm
            $(".delete-btn").click(function () {
                $('#deleteModal').modal({
                    backdrop: 'static',
                    keyboard: false
                });
            });

            // show edit confirm
            $(".edit-btn").click(function () {
                $('#editModal').modal({
                    backdrop: 'static',
                    keyboard: false
                });
            });
        });
    </script>

</body>
</html>