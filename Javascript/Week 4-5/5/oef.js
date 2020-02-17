let form = document.getElementById("form");
let output = document.getElementById("c");
form.addEventListener("input", calculate);

function calculate() {
    if (!check(a.value) || !check(b.value)) {
        output.value = "U heeft geen geldige getallen ingegeven";
    } else {
        output.value = "Het product van " + a.value + " en " + b.value + " is " + a.value * b.value;
    }
    document.body.appendChild(output);
}

function check(val){
    return /^(-)?\d+$/.test(val)
}