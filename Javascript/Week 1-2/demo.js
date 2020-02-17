/*
console.log("demo");
let v = 1;
console.log(v);
console.log(typeof v);
let aantal = 1;
let waarde;
waarde = 1;
let a, b = 1, c;

let getal = 12;
console.log(`${getal}+1=${getal + 5}`);
console.log(typeof (getal));

function faculteit(n) {
    return (n === 0 || n === 1) ? 1 : n * faculteit(n - 1);
}

console.log(faculteit(5));
*/

console.log("oef1:");
let aantalLijnen = 7;
let tags = "";
for (let tags = "#"; tags.length <= aantalLijnen; tags += "#") {
    console.log(tags)
}

tags = "";
let spaties = "      ";
console.log("oef2");
for (let i = 0; i < aantalLijnen; i++) {
    tags += "#";
    console.log(spaties.substr(i) + tags);
}

console.log("oef3")
spaties = "       ";
tags = "#";
console.log(spaties + tags)
for (let i = 0; i < aantalLijnen; i++) {
    tags += "##";
    console.log(spaties.substr(i + 1) + tags);
}