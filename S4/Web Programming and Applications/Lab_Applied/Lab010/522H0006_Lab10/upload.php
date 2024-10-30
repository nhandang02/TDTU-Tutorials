<?php
// Check if form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Define allowed file extensions
    $allowedExtensions = array("txt", "doc", "docx", "xls", "xlsx", "jpg", "png", "mp3", "mp4", "pdf", "rar", "zip");
    
    // Define maximum file size in bytes (500 MB)
    $maxFileSize = 500 * 1024 * 1024;
    
    // Destination folder for uploads
    $uploadDirectory = "upload/";
    
    // Retrieve file details
    $fileName = $_FILES["document"]["name"];
    $fileSize = $_FILES["document"]["size"];
    $fileTmpName = $_FILES["document"]["tmp_name"];
    $fileType = $_FILES["document"]["type"];
    $fileExtension = strtolower(pathinfo($fileName, PATHINFO_EXTENSION));
    
    // Check if file type is allowed
    if (!in_array($fileExtension, $allowedExtensions)) {
        $response = array(
            "success" => false,
            "message" => "Error: This file type is not allowed."
        );
        echo json_encode($response);
        exit();
    } elseif ($fileSize > $maxFileSize) { // Check file size
        $response = array(
            "success" => false,
            "message" => "Error: File exceeds the maximum allowed size."
        );
        echo json_encode($response);
        exit();
    } elseif (file_exists($uploadDirectory . $fileName)) { // Check if file already exists
        $response = array(
            "success" => false,
            "message" => "Error: This file already exists."
        );
        echo json_encode($response);
        exit();
    } else {
        // Move the file from temporary directory to upload directory
        if (move_uploaded_file($fileTmpName, $uploadDirectory . $fileName)) {
            $response = array(
                "success" => true,
                "message" => "File uploaded successfully.",
                "fileName" => $fileName,
                "fileSize" => $fileSize,
                "fileUrl" => $uploadDirectory . $fileName
            );
            echo json_encode($response);
            exit();
        } else {
            $response = array(
                "success" => false,
                "message" => "Error uploading file."
            );
            echo json_encode($response);
            exit();
        }
    }
}
?>
