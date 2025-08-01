/*
 * Crie uma variável com a nota de um aluno (exemplo: let nota = 7;)
 * E use um if / else if / else pra mostrar:
 *
 * Se a nota for >= 7 → "Aprovado"
 * Se a nota for >= 5 e menor que 7 → "Recuperação"
 * Se for menor que 5 → "Reprovado"
 *
 */

let nota = 4

if(nota >= 7){
    console.log("Aprovado")
} else if (nota >= 5 && nota < 7){
    console.log("Recuperação")
} else if(nota < 5){
    console.log("Reprovado")
} else {
    console.log("Número inválido!")
}