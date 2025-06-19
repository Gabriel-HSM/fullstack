function calcularIMC(altura, peso){//peso / (altura * altura)
    return  peso / (altura * altura)
}

function avaliarIMC(imc){
    if(imc < 18.5){
        return "Abaixo do peso"

    } else if (imc >= 18.5 && imc <= 24.9){
        return "Peso Normal"

    } else if (imc >= 25 && imc <= 29.9){
       return "Sobrepeso"

    } else if (imc > 30){
        return "Obesidade"

    } else {
        return "Dados inválidos! Por favor revise"
    }
}

let imc = calcularIMC(60, 1.73)
let avaliação = avaliarIMC(imc)