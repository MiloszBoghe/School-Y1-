console.log(fibo(5));

function fibo(n) {
    return n === 0 ? 1 : n === 1 ? 1 : n === 2 ? 1 : fibo(n - 1) + fibo(n - 2);
}

function brentNaci(n) {
    if (n === 0 || n === 1) {
        return 1;
    } else if (n === 2) {
        return 1;
    } else {
        return fibo(n - 1) + fibo(n - 2);
        //
    }
}
