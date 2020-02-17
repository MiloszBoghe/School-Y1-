'use strict';
//let name = 'tim';
//console.log(name);
/*
function canYouSpotTheProblem(){
    for (let counter = 0 ; counter < 5; counter++){
        console.log("happy");
    }
}
canYouSpotTheProblem();
*/
function Person(naam) {
    this.name = naam;
}

try {
    let ferdinand = new Person("Ferdinand");
    console.log(ferdinand.name);
} catch (error) {
    console.log(error.toString());
} finally {
    console.log("done")
}

//console.log(global.name);


