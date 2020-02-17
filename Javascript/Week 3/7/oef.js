
class Date {
    constructor(day, month, year) {
        this._year = year;
        this.month = month;
        this._day = day;
    }

    get day() {
        return this._day;
    }

    set day(value) {
        this._day = value;
    }

    get month() {
        return this._month;
    }

    set month(value) {
        while(value>12){
            value=value-12;
            this._year++;
        }
        this._month = value;
    }

    get year() {
        return this._year;
    }

    set year(value) {
        this._year = value;
    }

    print() {
        console.log(this._day+"/"+this._month+"/"+this._year);
    }

    printMonth() {
        console.log(this._day+"/"+Date.MONTHS[this._month]+"/"+this._year);
    }

    static make(day,month,year){
        return new Date(day,month,year);
    }
}
Date.MONTHS = ["", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];


let date = Date.make(1,12,2001);

date.printMonth();






