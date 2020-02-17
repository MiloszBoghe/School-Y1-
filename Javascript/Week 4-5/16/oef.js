let images = Array.from(document.getElementsByTagName("img"));
console.log(images);
let alt = document.getElementById("bijschrift");
images.forEach(img => {
    img.addEventListener("dblclick", engorgio);
});

function engorgio(e) {
    alt.innerText = e.target.getAttribute("alt");
    e.target.setAttribute("style","width:200px;");
    e.target.addEventListener("click",reset);
}

function reset(e){
    e.target.setAttribute("style","width:100px;");
    alt.innerText="";
}
