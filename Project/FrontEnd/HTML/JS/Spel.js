'use strict';
let guid = sessionStorage.getItem("guid");
let playerid = sessionStorage.getItem("player-id");
let redirect = window.location.toString().split("Spel")[0];
let gameOver = false;
let color = "";
let round = 0;
let guess = 0;
let childrens = [];

let colors = Array.from(document.getElementsByClassName("colors"));
colors.forEach(e => {
    e.addEventListener("click", pickedColor)
});

let checkButton = Array.from(document.getElementsByClassName("checkButton")).reverse();
checkButton.forEach(e => {
    e.addEventListener("click", postGuess)
});

let rows = Array.from(document.getElementsByTagName("span")).reverse();
rows.shift();
let turn = document.getElementsByClassName("YetToMove")[0];
turn.setAttribute("style", "display:block;");
let pinRows = Array.from(document.getElementsByClassName("form-pin")).reverse();
let canGuess = "";

$(function () {
    getGame();
    let leaveButton = document.getElementsByClassName("leaveSpel");
    leaveButton[0].setAttribute("lobby-id", sessionStorage.getItem("lobby-id"));
    leaveButton[0].addEventListener("click", leaveLobbyByButton);
});

setInterval(getGame, 1000);

function getGame() {
    let url = "https://51.83.41.81:44317/api/Games/" + guid;
    $.ajax({
        xhrFields: {
            withCredentials: false
        },
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + sessionStorage.getItem('token'));
        },
        url: url,
        success: function (e) {
            let playerHistories = e.playerHistory;
            let playerHistory;
            let num = 0;
            let colors = [];
            let temp = 0;
            turn.textContent = "Waiting on ";
            Object.keys(playerHistories).forEach(key => {
                if (key === playerid) {
                    playerHistory = playerHistories[key];
                    guess = playerHistory.length;
                }
                if (guess > playerHistories[key].length) {
                    num++
                }
                if (playerHistories[key].length === 10) {
                    temp++;
                }

                for (let i = 0; i < playerHistories[key].length; i++) {
                    let correct = playerHistories[key][i].correctColorAndPositionAmount;
                    if (correct === 4) {
                        colors = playerHistories[key][i].colors;
                    }
                }
            });
            if (temp === e.players.length) {
                gameOver = true;
            }
            colors.reverse();
            for (let i = 0; i < colors.length; i++) {
                colors[i] = HexToColor(colors[i]);
            }
            sessionStorage.setItem("secret", colors);
            if (num === 0) {
                turn.textContent = "Your turn!";
            } else if (num === 1) {
                turn.textContent += num + " player";
            } else {
                turn.textContent += num + " players";
            }


            checkButton.forEach(e => {
                e.setAttribute("style", "visibility: hidden;");
            });
            if (guess < 10) {
                childrens = rows[guess].children;

                checkButton[guess].setAttribute("style", "visibility: visible;");
                round = e.currentRound;

                childrens = rows[guess].children;
            }
            for (let i = 0; i < guess; i++) {
                let correctColor = [];
                let correctColorAndPositionAmount = [];
                correctColor.length = playerHistory[i].correctColorAmount;
                correctColorAndPositionAmount.length = playerHistory[i].correctColorAndPositionAmount;

                let pinRow = Array.from(pinRows[i].children);

                for (let j = 0; j < correctColor.length; j++) {
                    pinRow[j].setAttribute("style", "background-color: White;");
                }
                for (let j = correctColor.length; j < correctColorAndPositionAmount.length + correctColor.length; j++) {
                    pinRow[j].setAttribute("style", "background-color: Red;");
                }
            }
            for (let i = 0; i < guess; i++) {
                let row = Array.from(rows[i].children).reverse();
                for (let j = 0; j < row.length; j++) {
                    row[j].setAttribute("style", "background-color: " + HexToColor(playerHistory[i].colors[j]) + ";");
                }
            }
            getStatus();
        },
        error: function (e) {
            if (e.status === 401) {
                alert('Not Logged in!!!!!');
                window.location.replace(redirect + 'index.html');
            }
        }
    });
}

function GetCanGuess() {
    let url = "https://51.83.41.81:44317/api/Games/" + guid + "/canguess/forround/" + round;

    fetch(url,
        {
            method: "GET",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        }).then((response) => {
        if (response.ok) {
            return response.json();
        } else {
            alert("GetCanGuess Error");
        }
    }).then((response) => {
        if (response.toLocaleString() === "1") {
            canGuess = "Ok";
        }
        else if (response.toLocaleString() === "500") {
            canGuess = "Must wait on others";
        } else if (response.toLocaleString() === "501") {
            canGuess = "Max amount of guesses reached";
        } else if (response.toLocaleString() === "502") {
            canGuess = "Round not started yet";
        } else if (response.toLocaleString() === "503") {
            canGuess = "Not allowed due to game status";
        }
    });
}


function postGuess() {
    GetCanGuess();
    let url = "https://51.83.41.81:44317/api/Games/" + guid + "/guess";
    let colors = [];
    for (let i = 0; i < childrens.length; i++) {
        let color = childrens[i];
        color = getColorByClassName(color.getAttribute("class"));
        colors.push(color);
    }
    if(!(colors.includes(null))){

    colors.reverse();
    let colorArray = {colors: colors};
    fetch(url, {
        method: "POST",
        body: JSON.stringify(colorArray),
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + sessionStorage.getItem("token")
        }
    })
        .then(function (response) {
            if (!response.ok) {
                alert(canGuess);
            }
        })
    }
    else{
        alert("Vul 4 kleuren in.");
    }
}

function getStatus() {
    let url = "https://51.83.41.81:44317/api/Games/" + guid + "/status";
    fetch(url,
        {
            method: "GET",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token")
            }
        }).then((response) => {
        if (response.ok) {
            return response.json();
        }
        else if (response.status === 401) {
            alert('Not Logged in!!!!!');
            window.location.replace(redirect + 'index.html');
        }
    }).then((response) => {
            if (!gameOver) {
                gameOver = response.gameOver;
            }
            if (gameOver) {
                leaveLobby(sessionStorage.getItem("lobby-id"));
                if (response.finalWinner === null) {
                    alert("Geen winnaar!");
                    window.location.replace(redirect + "Loser.html");
                } else {
                    sessionStorage.setItem("winner", response.finalWinner.nickName);
                    alert(sessionStorage.getItem("winner") + " heeft het spel gewonnen! \n" + "Winnende kleuren: " + sessionStorage.getItem("secret"));
                    window.location.replace(redirect + "Winner.html");
                }
            }
        }
    )
}

function pickedColor(e) {
    color = e.target.getAttribute("class").split(" ")[0];
    for (let i = 0; i < childrens.length; i++) {
        childrens[i].addEventListener("click", fillColor);
    }
}

function fillColor(e) {
    e.target.setAttribute("class", color);
}

function getColorByClassName(color) {
    switch (color) {
        case "b_black":
            return "000000";
        case "b_white":
            return "FFFFFF";
        case "b_red":
            return "FF0000";
        case "b_yellow":
            return "FFFF00";
        case "b_orange":
            return "FFA500";
        case "b_green":
            return "008000";
        case "b_blue":
            return "0000FF";
        case "b_purple":
            return "800080";
        default:
            return null;
    }
}

/**
 * @return {string}
 */

function HexToColor(color) {
    switch (color) {
        case "000000":
            return "Black";
        case "FFFFFF":
            return "White";
        case "FF0000":
            return "Red";
        case "FFFF00":
            return "Yellow";
        case "FFA500":
            return "Orange";
        case "008000":
            return "Green";
        case "0000FF":
            return "Blue";
        case "800080":
            return "Purple";
        default:
            return null;
    }
}

function leaveLobbyByButton(e) {

    let id = e.target.getAttribute("lobby-id");
    let url = "https://51.83.41.81:44317/api/WaitingRooms/" + id + "/leave";
    fetch(url,
        {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + sessionStorage.getItem("token"),
            }
        })
        .then((response) => {
            if (response.status === 200) {
                window.location.replace(redirect + "LobbyList.html");
            } else if (response.status === 400) {
                window.open('LobbyList.html', "_self");
            }
        });
}

function leaveLobby(id) {
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
            if (response.status === 200) {

            }
        });
}