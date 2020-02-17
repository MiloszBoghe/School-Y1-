const MOUNTAINS = [
    {
        name: "Kilimanjaro",
        height: 5895,
        place: "Tanzania"
    },
    {
        name: "Everest",
        height: 8848,
        place: "Nepal"
    },
    {
        name: "Mount Fuji",
        height: 3776,
        place: "Japan"
    },
    {
        name: "Vaalserberg",
        height: 323,
        place: "Netherlands"
    },
    {
        name: "Denali",
        height: 6168,
        place: "United States"
    },
    {
        name: "Popocatepetl",
        height: 5465,
        place: "Mexico"
    },
    {
        name: "Mont Blanc",
        height: 4808,
        place: "Italy/France"
    }
];

let table = document.createElement("table");
table.setAttribute("border", 1);
let keys = Object.keys(MOUNTAINS[0]);
let tr = document.createElement("tr");
keys.forEach(key => {
    let th = document.createElement("th");
    th.innerText = key;
    tr.appendChild(th);
    table.appendChild(tr);
});

MOUNTAINS.forEach(m => {
    let tr = document.createElement("tr");
    console.log(m);
    keys.forEach(key => {
        let td = document.createElement("td");
        td.innerText = m[key];
        if (typeof m[key] === "number") {
            td.style.textAlign = "right";
        }
        tr.appendChild(td);
    });
    table.appendChild(tr);
});


document.body.appendChild(table);

