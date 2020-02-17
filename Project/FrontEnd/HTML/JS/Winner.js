$(function () {
    document.getElementById("my_audio").play();
    let winner = document.getElementsByClassName("winner-name")[0];
    let text = document.createTextNode(sessionStorage.getItem("winner"));
    winner.appendChild(text);
});



