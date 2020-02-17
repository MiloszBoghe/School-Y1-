const hummus = function(){
    const ingredient = function(){

    }
};






const generateMultiplier=function(factor){
    return function(number){
        return number*factor;
    }
};
const twice = generateMultiplier(2);
console.log(twice(5));