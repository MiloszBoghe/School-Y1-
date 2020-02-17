/*
let protoRabbit = {
    speak(line) {
        console.log(`${this.type} says '${line}'`)
    }
};
let killerRabbit = Object.create(protoRabbit);
killerRabbit.type="killer";
killerRabbit.speak('SKRAAAAA!');
protoRabbit.type="prototype rabbit";
protoRabbit.speak("ugh.. retard..");
killerRabbit.speak("REEEEEEEEEEE");


let Rabbit = function(type){
    this.type=type;
};

Rabbit.prototype.speak = function(line){
    console.log(`${this.type} says '${line}'`);
};
Rabbit.prototype.toString = function(){
    return `A ${this.type} rabbit`;
}

let fatRabbit= new Rabbit("fat");

fatRabbit.speak("huh");
console.log(fatRabbit.toString());
fatRabbit = fatRabbit.delete;
console.log(fatRabbit);

class Rabbit {
    constructor(type) {
        this.type = type;
    }

    speak(line) {
        console.log(`${this.type} says '${line}'`)
    }

    toString() {
        return `A ${this.type} rabbit`
    }

    set type(type) {
        if (type == undefined) {
            this._type = "gewoon";
        } else {
            this._type = type;
        }
    }

    get type() {
        return this._type;
    }

}

let weirdRabbit = new Rabbit("weird");
weirdRabbit.speak("huh");
console.log(weirdRabbit.toString());
weirdRabbit.type = "kaka";
console.log(weirdRabbit.type);

let rabbit = new Rabbit();
console.log(rabbit.type);

class Person {
    constructor(name) {
        this.name = name;
    }

    set name(name) {
        if (name == false) {
            this._name = "lol";
        } else {
            this._name = name;
        }
    }

    get name() {
        return this._name;
    }
}

person = new Person("");
console.log(person.name);
*/

class Animal {
    constructor(name) {
        this.name = name;
        this.speed = 0;
    }

    run(speed) {
        this.speed += speed;
        console.log(`This rabbit runs with speed ${speed}`)
    }

    set name(name) {
        this._name = name;
    }

    get name() {
        return this._name;
    }
}

class Rabbit extends Animal {
    hide() {
        console.log(`${this.name} hides!`);
    }
}

let rabbit = new Rabbit("White rabbit");
rabbit.run(5);
rabbit.hide();
console.log(rabbit instanceof Animal);
console.log(rabbit instanceof Rabbit);