//1
function minimum(...nummers) {
    let minimum = Infinity;
    for (let nummer of nummers) {
        minimum = minimum <= nummer ? minimum : nummer;
    }
    return minimum;
}

//console.log(minimum(5, 7, 8, 10, 32, 1456, 3));


//2
function isEven(n) {
    if (n === 0) {
        return true
    } else if (n === 1) {
        return false;
    } else {
        return isEven(n - 2);
    }
}

//console.log(isEven(8));

//3
function fibonacci(n) {
    return n === 0 || n === 1 ? 1 : fibonacci(n - 2) + fibonacci(n - 1);
}

//console.log(fibonacci(5));


//4
function telB(woord) {
    let teller = 0;
    for (let i = 0; i < woord.length; i++) {
        'B' === woord.charAt(i) ? teller++ : 0;
    }
    return teller;
}

function telChar(woord, c) {
    let teller = 0;
    for (let i = 0; i < woord.length; i++) {
        c === woord.charAt(i) ? teller++ : 0;
    }
    return teller;
}

//console.log(telB("BananenB"));
//console.log(telChar("Bananenzijnkromaaa", 'a'));

//5
function maakRij(a, b, c) {
    c = c || 1;
    let result = [];
    if (c > 0) {
        for (let i = a; i <= b; i += c) {
            result.push(i);
        }
    } else {
        for (let i = a; i >= b; i += c) {
            result.push(i);
        }
    }
    return result;
}

console.log(maakRij(5, 1, -2));


//6
function reverseArray(a) {
    let reverse = [];
    for (let i = a.length; i > 0; i--) {
        reverse.push(i);
    }
    return reverse;
}

console.log(reverseArray([1, 2, 3, 4, 5, 6, 7, 8, 9]));
