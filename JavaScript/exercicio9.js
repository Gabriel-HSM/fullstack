function calcular(num1, num2, operacao){
    if((operacao == "somar") || (operacao == "subtrair") || (operacao == "multiplicar") || (operacao == "dividir")){


        switch(operacao){
            case "somar":
                return num1 + num2
                break;
            case "subtrair":
                return num1 - num2
                break;
            case "multiplicar":
                return num1 * num2
                break;
            case "dividir":
                return num1 / num2
                break;
            default:
                return err = 0
        }

    } else {console.log("Operação inválida! Observe se escreveu da forma correta! Somar,subtrair, dividir ou multiplicar")}

  
}


    let resultado = calcular(8,8,"multiplicar")
    console.log(`Resultado da operação é ${resultado}`);

