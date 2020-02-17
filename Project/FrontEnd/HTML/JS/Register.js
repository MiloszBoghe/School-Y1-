'use strict';
let error = document.getElementsByTagName("span")[0];

$(function () {
    let submitButton = document.getElementById('submit');
    submitButton.addEventListener("click", controle);
});

function controle() {

    showError();
    let correct;
    let input = Array.from(document.getElementsByTagName("input"));
    let username = input[0].value;
    let pass = input[1].value;
    let pass2 = input[2].value;
    let email = input[3].value;
    let email2 = input[4].value;
    let count = 0;

    if (email !== email2) {
        error.textContent = "E-mail komt niet overeen";
    } else if (email.split("@")[0] === "" || !email.endsWith("@student.pxl.be")) {
        error.textContent = "E-mail moet iets voor de @ bevatten en E-mail moet eindigen op @student.pxl.be";
    } else {
        count++;
    }


    if (email === "" || email2 === "") {
        error.textContent = "E-mail mag niet leeg zijn";
    } else {
        count++;
    }

    if (pass !== pass2) {
        error.textContent = "Wachtwoorden komen niet overeen"
    } else if (!checkPass(pass)) {
        error.textContent = "Wachtwoord moet een kleine letter, grote letter, cijfer en symbool bevatten.";
    } else {
        count++
    }

    if (username === "") {
        error.textContent = "Vul gebruikersnaam in";
    } else {
        count++;
    }


    correct = count === 4;

    if (correct) {
        let url = "https://51.83.41.81:44317/api/Authentication/register";
        let nickname = document.getElementById("nickname").value;
        let password = document.getElementById("password").value;
        let email = document.getElementById("email").value;
        let RegisterModel = {Email: email, Password: password, NickName: nickname};
        fetch(url,
            {
                method: "POST",
                body: JSON.stringify(RegisterModel),
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                }
            })
            .then((response) => {
                if (response.ok) {
                    hideElement();
                    login();
                } else {
                    error.textContent = "E-mail bestaat al";
                }
            })
    }
}


function checkPass(pass) {
    let upperCase = /[A-Z]/g;
    let lowerCase = /[a-z]/g;
    let numbers = /[0-9]/g;
    let symbols = /[%#*$./_,&|@'{[§!]/g;

    return pass.match(symbols) && pass.match(lowerCase) && pass.match(upperCase) && pass.match(numbers);
}

function login() {
    let url = "https://51.83.41.81:44317/api/Authentication/token";
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;
    let LoginModel = {Email: email, Password: password};
    fetch(url,
        {
            method: "POST",
            body: JSON.stringify(LoginModel),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
        .then((response) => {
            if (response.status === 200) {
                return response.json();
            }
        }).then((response) => {
        sessionStorage.setItem("token", response.token);
        window.open('index.html', "_self");
    });
}

function hideElement() {
    error.setAttribute("style", "display:none;");

}

function showError() {
    error.setAttribute("style", "display:block;");
}