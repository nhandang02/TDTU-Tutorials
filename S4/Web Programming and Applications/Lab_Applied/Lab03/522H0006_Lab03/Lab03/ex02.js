function validateData() {
    let txtFName = document.getElementById('firstname');
    let txtLName = document.getElementById('lastname');
    let txtEmail = document.getElementById('email');

    let FName = txtFName.value;
    let LName = txtLName.value;
    let email = txtEmail.value;
    let errMsg = '';

    if (FName == null || FName == '') {
        errMsg = 'Please enter your fist name';
    }
    else if (FName == null || LName == '') {
        errMsg = 'Please enter your last name';
    }
    else if (email == null || email == '') {
        errMsg = 'Please enter your email';
    }
    else if (! email.includes('@')) {
        errMsg = 'Your email is not correct';
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

function Add() {
    if (!validateData()) {
        return; 
    }

    let txtFName = document.getElementById('firstname');
    let txtLName = document.getElementById('lastname');
    let txtEmail = document.getElementById('email');

    let FName = txtFName.value;
    let LName = txtLName.value;
    let email = txtEmail.value;

    let table = document.getElementsByTagName('table')[0]
    let row = table.insertRow(-1);

    let c1 = row.insertCell(0);
    let c2 = row.insertCell(1);
    let c3 = row.insertCell(2);
    let c4 = row.insertCell(3);

    c1.innerText = FName;
    c2.innerText = LName;
    c3.innerText = email;
    c4.innerHTML = '<button onclick="Del(this)" class="btn btn-danger btn-sm">Delete</button>';

}

function Del(aButton) {
    let td = aButton.parentElement;
    let tr = td.parentElement;
    tr.remove();
}

function resetForm() {
    let txtFName = document.getElementById('firstname');
    let txtLName = document.getElementById('lastname');
    let txtEmail = document.getElementById('email');

    txtFName.value = ''; 
    txtLName.value = ''; 
    txtEmail.value = ''; 

    let lblErrMsg = document.getElementsByClassName('errorMessage')[0];
    lblErrMsg.innerText = ''; 

    lblErrMsg.classList.add('d-none'); 
}