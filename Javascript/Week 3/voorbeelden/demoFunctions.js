/*
function square(x) {
    return x * x;
}

console.log("Eerste manier: " + square(2));


const square2 = function (x) {
    return x * x;
};
console.log("Tweede manier: " + square2(3));


const square3 = (x) => {
    return x * x
};

console.log("Derde manier: " + square3(8));

function faculty(n) {
    return n === 0 ? 1 : n * faculty(n - 1);
}

console.log("Faculteit: " + faculty(5));


let safeMode = true;
let launchMissiles = function () {
    console.log("Launching missiles!!")
};

if (safeMode) {
    launchMissiles = function () {
        console.log("Nothing happens!")
    }
}
console.log("Launch Missiles: ");
launchMissiles();

const bark = () => {
    console.log("wafwaf");
};
console.log("Blaffen:");
bark();

const power = (base, exponent) => {
    let result = 1;
    for (let i = 0; i < exponent; i++) {
        result *= base;
    }
    return result;
};
console.log("Power: " + power(2, 3));

function minus(a, b) {
    return b === undefined ? -a : a - b;
}

console.log("minus:");
console.log(minus(3));
console.log(minus(8, 3));


function power1(base, exponent) {
    return exponent === 0 ? 1 : base * power1(base, exponent - 1);
}

console.log("power met recursie: ");
console.log(power1(5,2));


function faculty(n) {
    return n === 1 ? 1 : n * faculty(n - 1);
}

console.log(faculty(5));
*/



function findSolution(target) {
    function find(current, history) {
        console.log(`find: ${current} = ${history}`);
        if (current == target) {
            return history;
        } else if (current > target) {
            return null;
        } else {
            return find(current + 5, `(${history} + 5)`) ||
                find(current * 3, `(${history} * 3)`);
        }
    }
    return find(1, "1");

}
console.log(findSolution(13));



