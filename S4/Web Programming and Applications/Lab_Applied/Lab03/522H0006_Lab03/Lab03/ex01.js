function validateData() {
    let txtEmail = document.getElementById('email');
    let txtPwd = document.getElementById('pwd');

    let email = txtEmail.value;
    let pwd = txtPwd.value;
    let errMsg = '';

    if (email == null || email == '') {
        errMsg = 'Please enter your email';
    }
    else if (! email.includes('@')) {
        errMsg = 'Your email is not correct';
    }
    else if (pwd == null || pwd == '') {
        errMsg = 'Please enter your password';
    }
    else if (pwd.length < 6 ) {
        errMsg = 'Your password must contain at least 6 characters';
    }

    let lblErrMsg = document.getElementsByClassName('errorMessage')[0];
    lblErrMsg.innerText = errMsg;

    if (errMsg != '') {
        lblErrMsg.classList.remove('d-none');
        return false;
    }

    lblErrMsg.classList.add('d-none');
    return true;

}