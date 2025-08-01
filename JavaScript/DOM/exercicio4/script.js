let cores = ["blue", "red", "green", "yellow","orange","brown", "purple", "pink", "white", "gold"]

//Mach.random cria um número eleatório gigante... então utilizo Math.floor para arrendondar para seu inteiro mais próximo.. ex: 7.85641 = 8



function clicou(){
    let bodyJs = document.getElementById("bodyJs")
    let cor = Math.floor(Math.random() * 10)

    bodyJs.style.backgroundColor = cores[cor]
    


    
    
    

}