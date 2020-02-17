/*
let person = {
    name: "Tim", age: 24,
    print() {
        console.log(`naam : ${this.name}, leeftijd ${this.age}`)
    },
    setName(name){
        this.name=name;
    },
    getName(){
        return this.name;
    }
};

person.print();
person.setName("reee");
console.log(person.getName());

let id = Symbol("id");
let person = {
    [id] : 1, name:"Lisa",print(){
        console.log(`naam: ${this.name}, id: ${this[id]}`)
    }
};
person.print();

let ids = Symbol("id");
let name = "Lisa";
let name2 = "Lisa";
console.log(id===ids);


let name = "Satan";
let nameIterator = name [Symbol.iterator]();

let element = nameIterator.next();
while (!element.done){
    console.log(element.value);
    element=nameIterator.next();
}

for(let value of nameIterator){
    console.log(value);
}


let rabbit= {};
rabbit.speak=function (line){
    console.log(`The rabbit says: ${line}`);
};
rabbit.speak("I love chicken wings!");

function speak(line) {
    console.log(`The ${this.type} rabbit says: ${line}`);
}

let whiteRabbit = {type: "white", speak};

console.log(whiteRabbit);
whiteRabbit.speak("oh my ears..");
let black = {type: "black"};

speak.call(black, "Burp!");

function print() {
    printName = () => {
        console.log(this.name.toUpperCase());
    };
    printName();
}

let person = {name: "Tim", print};
person.print();

let ages = new Map();
ages.set("Boris", 39);
ages.set("Liang", 22);
ages.set("Julia", 60);

console.log(`Julia is ${ages.get("Julia")}`);
console.log(ages.has("Jack"));
console.log(ages.has("toString"));
for (let age of ages) {
    console.log(age);
}
*/







let pieter = {name:"pieter",geslacht:"man"};
console.log(pieter["geslacht"]);