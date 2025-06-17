/*Crie um array com 5 nomes de pessoas.
Crie uma função chamada mostrarNomes que percorra o array e mostre no console assim:
Olá, Gabriel! Você é o número 1 da lista.
Olá, Maria! Você é o número 2 da lista.
Olá, João! Você é o número 3 da lista.
Olá, Ana! Você é o número 4 da lista.
Olá, Lucas! Você é o número 5 da lista.
*/

let nomes = ["Gabriel","Larissa","Cassio","Nildes","Allana"];

function mostrarNomes(){
    for(let contador = 0; contador < nomes.length; contador++){
        
        console.log(`Olá ${nomes[contador]} você é o número ${contador + 1} da lista`)
        
    };
};
mostrarNomes();