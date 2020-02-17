let punt1 = {x: 1, y: 1};
let punt2 = {x: 2, y: 2};

function berekenAfstand(punt, punt2) {
    let afstand = Math.sqrt(Math.pow((punt.x - punt2.x), 2) + Math.pow((punt.y - punt2.y), 2));
    console.log(afstand);
}

berekenAfstand(punt1,punt2);