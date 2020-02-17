'use strict';


let redirect = window.location.toString().split("Lobby")[0] + "Spel.html?id=";
let id = findGetParameter("id");
let started = false;

$(function () {
    getLobby(id);
    createLobbySettings();
    sessionStorage.setItem("lobby-id", id);
});

let arr = ["The Noob", "The Pro", "Henrik", "Legend", "The Loser", "The Amateur", "Toxic", "The Carry", "No hands", "No ears", "No skill", "Bottom Fragger", "Potato", "Copy-Paster", "DISABLED", "No Eyes", "The Devil Himself", "Sickboy", "9-Year old", "U moeder", "U vader", "U zus", "God", "C# is my city", "Jordy#", "JordySharp", "JensScript", "SatanScript", "TittyStreamer", "Uncles Basement", "Ventieldopje24", "Skinny pee pee", "Glanzend voorhoofd", "SnakeDestroyer"];
let arrsize = arr.length;

setInterval(getLobby, 2000);

function getLobby() {
    $.ajax({
        xhrFields: {
            withCredentials: false
        },
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + sessionStorage.getItem('token'));
        },
        url: "https://51.83.41.81:44317/api/WaitingRooms/" + id,
        success: function (e) {
            let gamemode = "unknown";
            switch (e.gameSettings.mode) {
                case 1:
                    gamemode = "normal";
                    break;
            }

            let repeat = "unknown";
            if (e.gameSettings.duplicateColorsAllowed === false) {
                repeat = "Geen herhaling"
            }
            else {
                repeat = "Herhaling toegestaan"
            }

            // LobbySettings
            $("#GameName").html(e.name);
            $("#GameMode").html("Gamemode:    " + gamemode);
            $("#CodeLengte").html("Lengte Code:    " + e.gameSettings.codeLength);
            $("#AmountOfColors").html("Aantal kleuren:    " + e.gameSettings.amountOfColors);
            $("#RepeatColors").html("Herhaling kleur:    " + repeat);
            $("#AmountOfGuesses").html("Aantal gokken:    " + e.gameSettings.maximumAmountOfGuesses);
            $("#AmountOfRounds").html("Aantal rondes:    " + e.gameSettings.amountOfRounds);
            started = e.gameHasStarted;
            sessionStorage.setItem("guid", e.gameId);

            if (e.users.length === 4) {
                startGame();
            }

            if (started) {
               window.location.replace(redirect + id);
            }

            if (e.creatorUserId !== sessionStorage.getItem("player-id")) {
                document.getElementById("start").setAttribute("disabled", "");
            }

            //PlayerSettings
            let players = document.getElementById("playerlist");
            players.innerHTML = "";
            $.each(e.users, function (index, value) {
                createPlayer(value)
            });
        }, error: function (e) {
            if (e.status === 401) {
                alert('Not Logged in!!!!!');
                window.open('index.html', "_self");
            }
            if (e.status === 404) {
                alert("Lobby doesn't exist");
                window.open('LobbyList.html', "_self");
            }
        }
    });

}

function leaveLobby() {
    let id = findGetParameter("id");
    let url = "https://51.83.41.81:44317/api/WaitingRooms/" + id + "/leave";
    fetch(url,
        {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        })
        .then((response) => {
            if (response.ok) {
                window.open('LobbyList.html', "_self");
            }
        });
}

function findGetParameter(parameterName) {
    let tmp = location.search.substr(1).split("=");
    return tmp[0] === parameterName ? decodeURIComponent(tmp[1]) : null;
}

function createPlayer(e) {

    let player = document.createElement("div");
    player.className += "card border-dark mb-3";

    let insult = document.createElement("div");
    insult.className += "card-header";
    insult.id += "insult";
    insult.textContent = arr[Math.floor(Math.random() * arrsize)];

    let body = document.createElement("div");
    body.className += "card-body text-dark";

    let text = document.createElement("h5");
    text.className += "card-title";
    text.textContent = e.nickName;

    body.appendChild(text);
    player.appendChild(insult);
    player.appendChild(body);
    document.getElementById("playerlist").appendChild(player);
}


function startGame() {
    let url = "https://51.83.41.81:44317/api/Games?waitingroomId=" + id;
    fetch(url,
        {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        })
        .then((response) => {
            if (response.status === 201) {
                alert("Game started!");
                return response.json();

            }
        }).then((response) => {
        sessionStorage.setItem("guid", response.id);
        window.location.replace(redirect + id);
    });
}

function createLobbySettings() {

    let card = document.createElement("div");
    card.className += "card border-dark mb-3";

    let header = document.createElement("div");
    header.className += "card-header";
    header.id += "GameName";


    let body = document.createElement("div");
    body.className += "card-body text-dark";

    let h5_1 = document.createElement("h5");
    h5_1.className += "card-title";
    h5_1.id += "GameMode";
    let text = document.createTextNode("GameMode");
    h5_1.appendChild(text);

    let h5_2 = document.createElement("h5");
    h5_2.className += "card-title";
    h5_2.id += "CodeLengte";
    text = document.createTextNode("Lengte code");
    h5_2.appendChild(text);

    let h5_3 = document.createElement("h5");
    h5_3.className += "card-title";
    h5_3.id += "AmountOfColors";
    text = document.createTextNode("Aantal kleuren");
    h5_3.appendChild(text);

    let h5_4 = document.createElement("h5");
    h5_4.className += "card-title";
    h5_4.id += "RepeatColors";
    text = document.createTextNode("Zelfde kleur herhalen");
    h5_4.appendChild(text);

    let h5_5 = document.createElement("h5");
    h5_5.className += "card-title";
    text = document.createTextNode("Aantal gokken");
    h5_5.id += "AmountOfGuesses";
    h5_5.appendChild(text);

    let h5_6 = document.createElement("h5");
    h5_6.className += "card-title";
    h5_6.id += "AmountOfRounds";
    text = document.createTextNode("Aantal spellen");
    h5_6.appendChild(text);

    let leave = document.createElement("button");
    leave.type += "button";
    leave.className += "btn btn-danger";
    leave.addEventListener("click", leaveLobby);
    text = document.createTextNode("Leave");
    leave.appendChild(text);
    leave.setAttribute("id", "leaveButton");

    let start = document.createElement("button");
    start.type = "button";
    start.className += "btn btn-success";
    start.setAttribute("id", "start");
    start.addEventListener("click", startGame);
    text = document.createTextNode("Start Game");
    start.appendChild(text);

    body.appendChild(h5_1);
    body.appendChild(h5_2);
    body.appendChild(h5_3);
    body.appendChild(h5_4);
    body.appendChild(h5_5);
    body.appendChild(h5_6);
    body.appendChild(leave);
    body.appendChild(start);
    card.appendChild(header);
    card.appendChild(body);
    document.getElementById("createLobbySettings").appendChild(card);
}
