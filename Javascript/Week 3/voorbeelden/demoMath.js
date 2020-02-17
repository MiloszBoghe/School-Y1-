function randomPointonCircle(radius){
    let angle= Math.random() *2*Math.PI;
    console.log(angle);
    return {x:radius*Math.cos(angle),y:radius*Math.sin(angle)}
}

console.log(randomPointonCircle(2));