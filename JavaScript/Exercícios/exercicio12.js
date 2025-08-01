function dividir(num1, num2){
    if(num2 == 0){
        return "Não é possivel dividr por 0"
    } else {
        return num1 / num2
    }
}

console.log(dividir(8,2))
console.log(dividir(8,0))