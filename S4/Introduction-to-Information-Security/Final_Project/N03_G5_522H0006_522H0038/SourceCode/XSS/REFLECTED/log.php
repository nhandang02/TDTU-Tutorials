<?php
if (isset($_GET['c'])) {
  file_put_contents('log.txt', $_GET['c'] . "\n", FILE_APPEND);
}
