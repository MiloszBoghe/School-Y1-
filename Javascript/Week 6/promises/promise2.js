function factorial(number) {
	console.log( `factorial(${number})`);
	let promise = new Promise((resolve,reject)=>{
		if(typeof number == 'number' && !isNaN(number)){
			let result=1;
			for (let i=1; i<=number;i++){
				result=result*i;
				if (result==Infinity){
					setTimeout(()=>{ reject(`${number}! = Infinity`); }, 3000*Math.random());
					break;
				}
			}
			if(result!=Infinity) {
				setTimeout(()=>{resolve(result);}, 3000*Math.random());
			}
		} else {
			setTimeout(()=>{reject(`${number} is not a number`);}, 3000*Math.random());
		}
   });
   return promise;
}

function double(number){
	let promise = new Promise((resolve,reject)=>{
		if(typeof number == 'number' && !isNaN(number)){
			let result=2 * number;
			if(result!=Infinity) {
				setTimeout(()=>{resolve(result);}, 3000*Math.random());
			}
		} else {
			setTimeout(()=>{reject(`${number} is not a number`);}, 3000*Math.random());
		}
   });
   return promise;
}


let array=[1,100, 10 ,'a', 1000, 5, 3, 20];

for (let element of array){
	factorial(element)
		.then( (result) => double(result) )
		.then( (result) => {console.log(`2*${element}! = ${result}`);} )
		.catch( (error) => {console.log(`rejected: ${error}`);} );
}

console.log('end main');
