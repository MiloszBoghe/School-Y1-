function telB(woord) {
  /*  let count = 0;
    for (let i = 0; i < woord.length; i++) {
        if(woord[i]==="B"){
            count++;
        }
    }
    console.log(count);
*/
  telChar(woord,"B");
}


function telChar(woord,char){
    let count = 0;
    for (let i = 0; i < woord.length; i++) {
        if(woord[i]===char){
            count++;
        }
    }
    console.log(count);
}
telB("bananBBbananbananbanban");

telChar("azdazpidpppna","p");