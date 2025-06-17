/*
 *  Crie uma função chamada calculadora que receba dois números e uma operação como parâmetro ("soma", "subtracao", "multiplicacao",  *  "divisao").
 */


let res

function calcular(n1, n2, operacao){
    
  if (operacao == "soma" || operacao == "subtracao"|| operacao == "divisao" || operacao == "multiplicacao")
    {

        if(operacao == "soma"){
        res = n1 + n2 
        console.log(`A soma de ${n1} e ${n2} é de ${res}`)

        } else if (operacao == "divisao"){
        res = n1 / n2
        console.log(`A divisão de ${n1} e ${n2} é de ${res}`)

        } else if (operacao == "multiplicacao"){
        res = n1 * n2
        console.log(`A multiplicacão de ${n1} e ${n2} é de ${res}`)

        } else if (operacao == "subtracao"){
        res = n1 - n2
        console.log(`A subtração de ${n1} e ${n2} é de ${res}`)

        } else {console.log("Operação inválida")}

    } else {console.log("Operação inválida, escreva sem acentos e sem ç")}
}
calcular(10, 2, "divisao")