console.log(min(5, 10, 32, 561, 4, 68, 5, 3, 2, 89));

function min(...num) {
    let min = num[0];
    num.forEach(num => {
        min = num < min ? num : min;
    });
    return min;
}

