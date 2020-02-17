let listofNumbers = [2, 3, 5, 7, 11, 2];
function sum(...numbers){
    let sum = 0;
    for (let number of numbers){
        sum+=number;
    }
    return sum;
}
/*
console.log(listofNumbers);
for (let i = 0;i<listofNumbers.length;i++){
    console.log(listofNumbers[i]);
}

console.log();
for (let number of listofNumbers){
    console.log(number);
}

console.log(listofNumbers.indexOf(2,1));

console.log(listofNumbers);
let first = listofNumbers.unshift(5);
console.log(first);
console.log(listofNumbers);


listofNumbers=listofNumbers.slice(2);
console.log(listofNumbers);
listofNumbers= listofNumbers.concat(listofNumbers);
console.log(listofNumbers);
let number=[5,2,61,561,1];
console.log(sum(...number));
*/

let waarden = [25,32,65,4,8,2,5,1,9,5,3,5,56,4,8,82,9,45,9,4];
let a;
let b;
[a,b] = waarden;
[a,b]=[a,b].reverse();
console.log(a);
console.log(b);

function printRij1([rij1,...rijen]){
    console.log(rij1;
}

let matrix=[[1,2],[3,4],[5,6]];
printRij1(matrix,listofNumbers);