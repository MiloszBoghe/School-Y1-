function calculate() {
    textarea.textContent =
        "Het product van "+firstNumber.value+" en "+ secondNumber.value+" is "+ parseInt(firstNumber.value) * parseInt(secondNumber.value);
}

let firstNumber = document.getElementsByTagName("input")[0];
let secondNumber = document.getElementsByTagName("input")[1];
let button = document.getElementsByTagName("button")[0];
let textarea = document.getElementsByTagName("textarea")[0];
button.addEventListener("click", calculate);
