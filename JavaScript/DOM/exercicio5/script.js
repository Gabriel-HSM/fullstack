
function clicou(){
    let nome = document.getElementById("nomeUsuario").value
     
    let validacao = document.getElementById("validacao")

    if(nome == "" || nome == " "){
        validacao.innerText = "Por favor, preencha o nome antes de enviar!"
    } else {
        validacao.innerText = `Obrigado, ${nome}! Formulário enviado.`
    }

}