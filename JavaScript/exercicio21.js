let vetor = [2, 4, 6, 8]

let somar = vetor.reduce(function somarTudo(total, vetor){
    return total + vetor
})

console.log(somar)