function rec(num) {
    return num === 0 ? true : num === 1 ? false : rec(num - 2);
}


console.log(rec(5));
console.log(rec(8));
console.log(rec(2316));