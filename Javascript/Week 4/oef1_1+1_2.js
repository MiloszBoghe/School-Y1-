const MOUNTAINS = [
    {name: "Kilimanjaro", height: 5895, place: "Tanzania"}, {
        name: "Everest",
        height: 8848,
        place: "Nepal"
    }, {name: "Mount Fuji", height: 3776, place: "Japan"}, {
        name: "Vaalserberg",
        height: 323,
        place: "Netherlands"
    }, {name: "Denali", height: 6168, place: "United States"}, {
        name: "Popocatepetl",
        height: 5465,
        place: "Mexico"
    }, {name: "Mont Blanc", height: 4808, place: "Italy/France"}
];

let propArray = Object.keys(MOUNTAINS[0]);
let tabel = document.createElement("table");
let tr = document.createElement("tr");
for (let prop of propArray) {
    let th = document.createElement("th");
    let text = document.createTextNode(prop);
    th.appendChild(text);
    tr.appendChild(th);
}
tabel.appendChild(tr);

for (let mnt of MOUNTAINS) {
    let tr = document.createElement("tr");
    for (let prop of propArray) {
        let td = document.createElement("td");
        let text = document.createTextNode(mnt[prop]);
        td.appendChild(text);
        if (typeof mnt[prop] === "number") {
            td.style.textAlign = "right";
        }
        tr.appendChild(td);
        tabel.appendChild(tr)
    }
}
tabel.setAttribute("id", "mountains");
document.body.appendChild(tabel);
tabel.setAttribute("border", "1");

function byTagName(node, element) {
    if ("rreee"){

    }
    let Array = [];
    return node.getElementsByTagName(element);
    Array.push();

}

