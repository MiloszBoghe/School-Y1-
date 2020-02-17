'use strict';
let previousRooms = [];

$(function () {
    availableRooms();
    let createButton = document.getElementById('CreateButton');
    let logoutButton = document.getElementById("logout");
    logoutButton.addEventListener("click", logout);
    createButton.addEventListener("click", create);
    document.getElementById("nick").textContent = sessionStorage.getItem("nickname");
});

setInterval(availableRooms, 2000);

function availableRooms() {
    let url = "https://51.83.41.81:44317/api/waitingrooms";
    fetch(url,
        {
            method: "GET",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        }).then(function (response) {
        if (response.status === 200) {
            response.json().then(function (data) {
                let div = document.getElementById("demo");
                div.innerHTML = "";
                for (let i in data) {
                    let room = data[i];
                    lobbyCreate(room.users.length + "/4", room.name, room.gameSettings.mode, room.id);
                }
                previousRooms = data;
            });

        } else {
            alert('Not Logged in!!!!!');
            window.open('index.html', "_self");
        }
    })
}

function create() {
    let url = "https://51.83.41.81:44317/api/waitingrooms";
    let redirect = window.location.toString().split("Lobby")[0] + "Lobby.html?id=";
    let gameName = document.getElementById("gameNaam").value;
    let gameMode = document.getElementById("gameMode").value;
    let codeLength = document.getElementById("lengteCode").value;
    let amountOfColors = document.getElementById("aantalKleuren").value;
    let duplicateColorsAllowed = document.getElementById("herhalendeKleur").value;
    if (duplicateColorsAllowed === "Nee") {
        duplicateColorsAllowed = false;
    } else if (duplicateColorsAllowed === "Ja") {
        duplicateColorsAllowed = true;
    }
    let amountOfGuesses = document.getElementById("aantalGokken").value;
    let amountOfGames = document.getElementById("aantalGames").value;

    let createGameModel = {
        Name: gameName,
        gameSettings: {
            GameMode: gameMode,
            CodeLength: codeLength,
            amountOfColors: amountOfColors,
            duplicateColorsAllowed: duplicateColorsAllowed,
            maximumAmountOfGuesses: amountOfGuesses,
            amountOfRounds: amountOfGames
        }
    };
    fetch(url,
        {
            method: "POST",
            body: JSON.stringify(createGameModel),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        })
        .then((response) => {
            if (response.status === 201) {
                return response.json();
                //$('#exampleModal').modal('hide');
            } else {
                alert(response.status + " " + response.statusText);
            }
        }).then((response) => {
            window.location.replace(redirect + response.id);
        }
    );
}

function joinLobby(e) {
    let redirect = window.location.toString().split("Lobby")[0] + "Lobby.html?id=";
    let id = e.target.getAttribute("data-lobby");
    $.ajax({
        xhrFields: {
            withCredentials: false
        },
        method: "POST",
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + sessionStorage.getItem('token'));
        },
        url: "https://51.83.41.81:44317/api/WaitingRooms/" + id + "/join",
        success: function () {
            window.location.replace(redirect + id);
        },
        error: function () {
            window.location.replace(redirect + id);
        }

    })
}

function logout() {
    sessionStorage.clear();
}

function lobbyCreate(amountOfPlayers, gamename, gamemode, id) {

    let lobby = document.createElement("div");
    lobby.className += "card text-center";

    let lobbyList = document.createElement("article");
    lobbyList.className += "lobby-list";

    let header = document.createElement("div");
    header.className += "card-header";

    let text = document.createTextNode(amountOfPlayers);
    header.appendChild(text);

    let body = document.createElement("div");
    body.className += "card-body";

    let h5 = document.createElement("h5");
    h5.className += "card-title";
    h5.textContent = gamename;

    let a = document.createElement("a");
    a.className += "btn btn-dark";
    a.setAttribute("style","color:white;");
    a.addEventListener("click", joinLobby);
    a.setAttribute("data-lobby", id);
    text = document.createTextNode("Join");
    a.appendChild(text);

    let footer = document.createElement("div");
    footer.className += "card-footer text-muted";
    text = document.createTextNode(gamemode);
    footer.appendChild(text);

    let lobbySpatie = document.createElement("div");
    lobbySpatie.className += "lobby-spatie";

    lobbyList.appendChild(header);
    body.appendChild(h5);
    body.appendChild(a);
    lobbyList.appendChild(body);
    lobbyList.appendChild(footer);
    lobbyList.appendChild(lobbySpatie);
    lobby.appendChild(lobbyList);
    document.getElementById("demo").appendChild(lobby);
}
