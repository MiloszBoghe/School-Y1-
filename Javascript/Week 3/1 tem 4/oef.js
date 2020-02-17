'use strict';

/*
let persoon = {

    naam: "Satan",
    voornaam: "Hell",
    geboorteDatum: new Date(1995, 7, 27),

    berekenLeeftijd() {
        let now = new Date();
        let leeftijd = now.getFullYear() - this.geboorteDatum.getFullYear();
        if (now.getMonth() < this.geboorteDatum.getMonth() || (now.getMonth() === this.geboorteDatum.getMonth() && now.getDate() < this.geboorteDatum.getDate())) {
            leeftijd -= 1 tem 4;
        }
        return leeftijd;
    },

    print() {
        console.log("naam: " + this.naam + "\nvoornaam: " + this.voornaam + "\nleeftijd: " + this.berekenLeeftijd());
    }
};

persoon.print();


class Person {
    constructor(naam, voornaam, geboorteDatum) {
        this.naam = naam;
        this.voornaam = voornaam;
        this.geboorteDatum = new Date(geboorteDatum);
    }

    berekenLeeftijd() {
        let now = new Date();
        let leeftijd = now.getFullYear() - this._geboorteDatum.getFullYear();
        let nextBirthday = new Date(now.getFullYear(), this._geboorteDatum.getMonth(), this._geboorteDatum.getDate());
        if (now < nextBirthday) {
            leeftijd -= 1 tem 4;
        }
        return leeftijd;
    }

    print() {
        console.log("naam: " + this.naam + "\nvoornaam: " + this.voornaam + "\nleeftijd: " + this.berekenLeeftijd());
    }

    get geboorteDatum() {
        return this._geboorteDatum;
    }

    set geboorteDatum(value) {
        this._geboorteDatum = value;
    }

    get naam() {
        return this._naam;
    }

    set naam(value) {
        this._naam = value;
    }

    get voornaam() {
        return this._voornaam;
    }

    set voornaam(value) {
        this._voornaam = value;
    }
}

let person = new Person("Satan", "Ikke", "1995 7 27");
let person2 = new Person("haha","lol","1995 8 30");



class Account {
    constructor(landcode, banknummer, posities, saldo) {
        this._landcode = landcode;
        this._banknummer = banknummer;
        this._posities = posities;
        this._saldo = saldo || 1000;
    }

    get saldo() {
        return this._saldo;
    }

    set saldo(value) {
        this._saldo = value;
    }

    get landcode() {
        return this._landcode;
    }

    set landcode(value) {
        this._landcode = value;
    }

    get banknummer() {
        return this._banknummer;
    }

    set banknummer(value) {
        this._banknummer = value;
    }

    get posities() {
        return this._posities;
    }

    set posities(value) {
        this._posities = value;
    }
*/

/*
    print() {
        let controleGetal = this._posities.replace(/ /g, "") % 97;
        console.log(this._landcode + " " + this._banknummer + " " + this._posities + controleGetal + "\nSaldo: " + this.saldo+"\n");
    }

    opnemen(bedrag) {
        if (bedrag <= 0) {
            console.log("U moet een bedrag hoger dan 0 opnemen.");
        } else if (bedrag > this.saldo) {
            console.log("Opnemen: €"+bedrag+" --> U heeft maar " + this.saldo + " op uw rekening.");
        } else {
            this.saldo -= bedrag;
            console.log("Opnemen: €"+bedrag+" --> U heeft " + bedrag + " euro opgenomen.\n" + "Saldo: €" + this.saldo + ".\n");
        }
    }

    storten(bedrag) {
        if (bedrag <= 0) {
            console.log("U moet een bedrag hoger dan 0 storten.")
        } else {
            this.saldo += bedrag;
            console.log("Storten: €"+bedrag+" --> U heeft €" + bedrag + " gestort.\n" + "Saldo: €" + this.saldo + ".\n");
        }
    }
}


let bankAcc = new Account("BE", 76, "0012 5879 09");
bankAcc.print();
bankAcc.storten(500);
bankAcc.opnemen(2000);
bankAcc.opnemen(500);


*/




