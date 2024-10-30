<?php
setcookie('abc', 'def'); 

if (isset($_POST['name']) && ! empty($_POST['name'])) {
  // Sanitize input
  // $name = sanitize_input($_POST['name']);

  // Don use sanitize input
  $name = $_POST['name'];

} else {
  $name = isset($_COOKIE['name']) ? $_COOKIE['name'] : '';
}

function sanitize_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data, ENT_QUOTES, 'UTF-8');
  return $data;
}

?>


<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="author">
    <title>XSS DEMO</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/mini.css/2.3.4/mini-dark.min.css">
  </head>
  <body>
    <header>
      <a href="index.php" class="logo">XSS Me</a>
      <a href="index.php" class="button">Home</a>
      <a href="index.php?page=About" class="button">About</a>
      <a href="index.php" class="button">DOM-based XSS</a>
    </header>
    <div class="container">
      <div class="row">
        <div class="col-sm-12">
          <ul class="breadcrumbs">
            <li><a href="index.php">Home</a></li>
          </ul>
          <?php if (isset($_GET['page']) && strtolower($_GET['page']) === 'about'): ?>
          <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
          tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
          quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
          consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
          cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
          proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
          <?php else: ?>
          <form action="index.php" method="post" accept-charset="utf-8" id="form">
            Your name: <input type="text" name="name" autofocus required>
            <button type="submit" class="primary">Say Hi!</button>
          </form>
          <?php endif; ?>

          <div id="name">
            <?php if ( ! empty($name)): ?>
            <span class="toast large">Hello, <?php //echo sanitize_input($name); ?> <?php echo $name; ?>!</span>
            <?php endif; ?>
          </div>
        </div>
      </div>
    </div>
  </body>
</html>