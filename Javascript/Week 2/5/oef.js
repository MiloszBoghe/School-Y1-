function maakRij(min, max) {
    let rij = [];
    for (min; min < max; min++) {
        rij.push(min);
    }
    rij.push(max);
    console.log(rij);
}

maakRij(1, 5);

function maakStapRij(min, max, stap) {
    stap = stap || 1;
    let rij = [];
    if (min < max) {
        for (min; min < max; min += stap) {
            rij.push(min);
        }
    }else{
        for (min; min > max; min += stap) {
            rij.push(min);
        }
    }
    rij.push(max);
    console.log(rij);
}

maakStapRij(1,5,2);
maakStapRij(5, 1, -2);