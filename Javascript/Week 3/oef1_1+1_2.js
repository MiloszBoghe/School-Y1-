//1
'use strict';

class Person {
    constructor(naam, voornaam, geboorteDatum) {
        this.naam = naam;
        this.voornaam = voornaam;
        this.geboorteDatum = new Date(geboorteDatum);
    }

    set naam(naam) {
        if(this._naam !== "Boghe"){
            naam="Boghe";
        }
        this._naam = naam;
    }

    get naam() {
        return this._naam;
    }

    set voornaam(voornaam) {
        this._voornaam = voornaam;
    }

    get voornaam() {
        return this._voornaam;
    }

    set geboorteDatum(geboorteDatum) {
        this._geboorteDatum = geboorteDatum;
    }

    get geboorteDatum() {
        return this._geboorteDatum;
    }

    berekenLeeftijd() {
        let now = new Date();
        let leeftijd = now.getFullYear() - this._geboorteDatum.getFullYear();
        if ((now.getMonth() <= this._geboorteDatum.getMonth()) && (now.getDate() < this._geboorteDatum.getDate())) {
            leeftijd--
        }
        return leeftijd
    }

    print() {
        console.log(`Naam: ${this._naam}\nVoornaam: ${this._voornaam} \nLeeftijd: ${this.berekenLeeftijd()} jaar`);
    }
}

let person = new Person("Boghe", "Satan", '1995,7,27');
person.print();


