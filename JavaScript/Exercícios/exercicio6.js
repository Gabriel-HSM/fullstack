/*
 *
 * Crie uma função chamada verificarBissexto que receba um ano como parâmetro e diga se ele é bissexto ou não.
 * Regras para ser bissexto:
 * O ano é múltiplo de 4
 * MAS não pode ser múltiplo de 100
 * A não ser que também seja múltiplo de 400
 */


function verificarBissexto(ano){
    if((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)){
        console.log(`O ano ${ano} é bissexto`)
    } else {
        console.log(`o ano ${ano} não é bissexto`)
    }
}

verificarBissexto(2000)