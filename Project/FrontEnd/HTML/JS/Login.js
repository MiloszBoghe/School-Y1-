'use strict';
window.addEventListener("load", loaded);

function loaded() {
    let loginButton = document.getElementById('login-button');
    loginButton.addEventListener("click", login);
}


function login(){
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
        }else{
            alert("foute login gegevens");
        }
    }).then((response) => {
    sessionStorage.setItem("token", response.token);
    sessionStorage.setItem("nickname",response.player.nickName);
    sessionStorage.setItem("player-id",response.player.id);
    window.open('LobbyList.html', "_self");
});
}