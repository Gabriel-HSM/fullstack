    let div1 = document.createElement("div")
    div1.style.textAlign = "center"
    div1.style.backgroundColor = "white"
    div1.style.width = "150px"
    div1.style.height = "250px"
    div1.style.margin = "auto"
    div1.style.borderRadius = "20px"
    
   
function clicou(){
    let entrada = document.getElementById("entradaElemento").value
    
    if(entrada == ""){
        window.alert("Escreva algo dentro do campo de texto")
    } else {

        document.body.appendChild(div1) //adiciona a Div após clicar no botão
        
        let paragrafo = document.createElement("p") //cria um parágrafo
        paragrafo.style.margin = 0
        paragrafo.style.padding = "5px"



        div1.appendChild(paragrafo) //colocando o parágrafo dentro da div    
        paragrafo.innerText = entrada //adiciona o contéudo escrito na entrada
    }
}