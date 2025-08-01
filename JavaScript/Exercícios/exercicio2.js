/*
 * Crie uma função que recebe uma idade como parâmetro e imprime:
 *
 *  Se a idade for menor que 18 → "Menor de idade"
 *  Se for igual ou maior que 18 → "Maior de idade"
 *
 */

function verificarIdade(idade){
    if(idade < 18){
        
        console.log(`Você tem ${idade} anos e é menor de idade`)
    
    } else {

        console.log(`Você tem ${idade} anos e é maior de idade`)
    }
};
verificarIdade(18)