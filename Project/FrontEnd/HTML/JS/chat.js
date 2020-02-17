"use strict";

let input = document.getElementById("messageInput");
input.addEventListener("keyup", function (event) {
    if (event.keyCode === 13) {
        event.preventDefault();
        document.getElementById("sendButton").click();
    }
})

let connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
connection.connection.baseUrl = "https://51.83.41.81:44317/chatHub";

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    let msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    let encodedMsg = user + ": " + msg;
    let li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
    document.getElementById("messageInput").value="";
    $('.scrollbar').scrollTop($('.scrollbar')[0].scrollHeight);
});

connection.start().then(function(){
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    let user = sessionStorage.getItem("nickname");
    let message = document.getElementById("messageInput").value;
    if(message!==""){
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    }
    event.preventDefault();
});