let opcao = 1
let date = new Date()

do{
    console.log("===== MENU =====")
    console.log("1 - Falar oi")
    console.log("2 - Mostrar data")
    console.log("3 - Sair")


    switch(opcao){
        case 1:
        console.log("Oi, tudo bem?")
        break;

        case 2:
        console.log(date)
        break;

        case 3:
        console.log("Saindo do programa")
        break;

        default:
        console.log("escreva um número com formato correto")
    }

    opcao++

}while(opcao <= 3)