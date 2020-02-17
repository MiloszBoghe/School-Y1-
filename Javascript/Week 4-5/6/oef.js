let button = document.getElementById("generate");
let inputs = document.getElementsByTagName("input");
button.addEventListener("click", generate);

function check(name) {
    let upperCase = /[A-Z]/g;
    let lowerCase = /[a-z]/g;
    let numbers = /[0-9]/g;
    let symbols = /[%#*$./_,&|@'{[§!]/g;
    return !name.match(symbols) && name.match(lowerCase) && name.match(upperCase) && !name.match(numbers);
}

function generate() {
    if (!check(inputs[0].value) || !check(inputs[1].value)) {
        inputs[2].value = "foute invoer";
    } else {
        inputs[2].value = "Welkom, " + inputs[0].value + " " + inputs[1].value;
    }
}
