let canvas = document.createElement("canvas");

canvas.setAttribute("width", "2000");
canvas.setAttribute("height", "2000");
canvas.setAttribute("border", "1");
document.body.appendChild(canvas);
//let ctx = canvas.getContext("2d");


canvas.addEventListener("mousedown", start);
canvas.addEventListener("mouseup", stop);
let context = canvas.getContext("2d");
context.strokeStyle = "black";
context.lineWidth = 3;
function start() {
    let e = window.event;
    context.beginPath();
    context.moveTo(e.pageX,e.pageY);
    canvas.addEventListener("mousemove", draw);
}

function draw() {
    let e = window.event;
    context.lineTo(e.pageX,e.pageY);
    context.stroke();

}

function stop() {
    context.closePath();
    canvas.removeEventListener("mousemove", draw);
}
/*
ctx.beginPath();
ctx.strokeStyle = "black";
ctx.lineWidth = 3;

ctx.lineTo(100, 100);
ctx.lineTo(180, 50);
ctx.lineTo(260, 100);
ctx.lineTo(100, 100);
ctx.lineTo(100, 200);
ctx.lineTo(260, 200);
ctx.lineTo(260, 100);
ctx.moveTo(160, 200);
ctx.lineTo(160, 140);
ctx.lineTo(200, 140);
ctx.lineTo(200, 200);

ctx.moveTo(200, 450);
ctx.quadraticCurveTo(120, 450, 120, 500);
ctx.lineTo(120, 520);
ctx.quadraticCurveTo(120, 570, 200, 570);

ctx.moveTo(220, 450);
ctx.lineTo(220, 570);
ctx.quadraticCurveTo(300, 570, 300, 520);
ctx.quadraticCurveTo(300, 450, 220, 450);


ctx.stroke();
*/


