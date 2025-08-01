//IMC = peso / (altura * altura)

function calcularImc(peso, altura){
    return peso / (altura * altura)
}

let imc = calcularImc(60, 1.73)
console.log(`Seu IMC é ${imc.toFixed(2)}`)