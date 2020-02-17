function reverseArray(arr) {
    let b = [];
    for (let i = arr.length - 1; i >= 0; i--) {
        b.push(arr[i]);
    }
    console.log(b);
}

let a = [1, 2, 3];
reverseArray(a);