<?php
include("db.php");

$username = "_nhandawng.15";
$password = "123456";

//Set cookie 
setcookie("username", $username, time() + (86400 * 30), "/"); 
setcookie("password", $password, time() + (86400 * 30), "/"); 



$sql = "SELECT user_name, comment, created_at FROM comments ORDER BY created_at DESC";
$result = $conn->query($sql);

$conn->close();
?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
  <meta http-equiv="x-ua-compatible" content="ie=edge" />
  <title>XSS DEMO</title>
  <!-- MDB icon -->
  <link rel="icon" href="img/mdb-favicon.ico" type="image/x-icon" />
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.2/css/all.css" />
  <!-- Google Fonts Roboto -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700;900&display=swap" />
  <!-- MDB -->
  <link rel="stylesheet" href="css/bootstrap-comments.min.css" />
</head>

<body>

  <!-- Start your project here-->
  <section style="background-color: #eee;">
    <div class="container my-5 py-5">
      <div class="row d-flex justify-content-center">
        <div class="col-md-12 col-lg-10 col-xl-8">
          <div class="card">
            <div class="card-body">
              <div class="d-flex flex-start align-items-center">
                <img class="rounded-circle shadow-1-strong me-3" src="avt.jpg" alt="avatar" width="60" height="60" />
                <div>
                  <h6 class="fw-bold text-primary mb-1">_nhandawng.15</h6>
                  <p class="text-muted small mb-0">
                    Shared publicly - Jan 2024
                  </p>
                </div>
              </div>

              <p class="mt-3 mb-4 pb-2">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                quis nostrud exercitation ullamco laboris nisi ut aliquip consequat.
              </p>

              <div class="small d-flex justify-content-start">
                <a href="#!" class="d-flex align-items-center me-3">
                  <i class="far fa-thumbs-up me-2"></i>
                  <p class="mb-0">Like</p>
                </a>
                <a href="#!" class="d-flex align-items-center me-3">
                  <i class="far fa-comment-dots me-2"></i>
                  <p class="mb-0">Comment</p>
                </a>
                <a href="#!" class="d-flex align-items-center me-3">
                  <i class="fas fa-share me-2"></i>
                  <p class="mb-0">Share</p>
                </a>
              </div>
            </div>

            <!----------------------Prvent XSS----------------------->
            <?php
            // if ($result->num_rows > 0) {
            //   while ($row = $result->fetch_assoc()) {
            //     echo '<div class="card-footer py-3 border-0" style="background-color: #f8f9fa;">';
            //     echo '<div class="d-flex flex-start w-100">';
            //     echo '<img class="rounded-circle shadow-1-strong me-3" src="avt.jpg" alt="avatar" width="40" height="40" />';
            //     echo '<div class="form-outline w-100">';
            //     echo '<p class="mb-1"><strong>' . htmlspecialchars($row["user_name"]) . '</strong></p>';
            //     echo '<p class="small text-muted">' . htmlspecialchars($row["created_at"]) . '</p>';
            //     echo '<p>' . nl2br(htmlspecialchars($row["comment"])) . '</p>';
            //     echo '</div></div></div>';
            //   }
            // } else {
            //   echo '<p>No comments yet.</p>';
            // }
            ?>
            <!----------------------Prvent XSS----------------------->

            <!----------------------Permit XSS----------------------->
            <?php
            if ($result->num_rows > 0) {
              while ($row = $result->fetch_assoc()) {
                echo '<div class="card-footer py-3 border-0" style="background-color: #f8f9fa;">';
                echo '<div class="d-flex flex-start w-100">';
                echo '<img class="rounded-circle shadow-1-strong me-3" src="avt.jpg" alt="avatar" width="40" height="40" />';
                echo '<div class="form-outline w-100">';
                echo '<p class="mb-1"><strong>' . $row["user_name"] . '</strong></p>';
                echo '<p class="small text-muted">' . $row["created_at"] . '</p>';
                echo '<p>' . nl2br($row["comment"]) . '</p>';
                echo '</div></div></div>';
              }
            } else {
              echo '<p>No comments yet.</p>';
            }
            ?>
            <!----------------------Permit XSS----------------------->

            <sd class="card-footer py-3 border-0" style="background-color: #f8f9fa;">
              <form method="post" action="submit_comment.php">
                <div class="d-flex flex-start w-100">
                  <img class="rounded-circle shadow-1-strong me-3" src="avt.jpg" alt="avatar" width="40" height="40" />
                  <div class="form-outline w-100">
                    <textarea class="form-control" name="comment" id="textAreaExample" rows="4" style="background: #fff;" required></textarea>
                    <label class="form-label" for="textAreaExample">Comment</label>
                  </div>
                </div>
                <div class="float-end mt-2 pt-1">
                  <button type="submit" class="btn btn-primary btn-sm">Post comment</button>
                  <button type="button" class="btn btn-outline-primary btn-sm">Cancel</button>
                </div>
              </form>
              <!-----------------------------Sanitize input--------------------------------->
              <!-- <script>
                document.querySelector('form').addEventListener('submit', function(event) {
                 
                  var commentInput = document.getElementById('textAreaExample');
                  var commentValue = commentInput.value;

                  var sanitizedComment = sanitizeHTML(commentValue);

                  commentInput.value = sanitizedComment;
                });

                // Function to santinize input
                function sanitizeHTML(str) {
                  return str.replace(/<[^>]*>?/gm, '');
                }
              </script> -->
              <!-----------------------------Sanitize input--------------------------------->
              </s>

          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- End your project here-->

  <!-- MDB -->
  <script type="text/javascript" src="js/mdb.min.js"></script>
  <!-- Custom scripts -->
  <script type="text/javascript"></script>
</body>

</html>