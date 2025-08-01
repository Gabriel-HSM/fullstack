let contador = 0

function clicou(){
    contador++

    let pClique = document.getElementById("pClique")

    if(contador == 1){
        pClique.innerText = `Você clicou ${contador} vez`
    } else {
        pClique.innerText = `Você clicou ${contador} vezes!`
    }

}