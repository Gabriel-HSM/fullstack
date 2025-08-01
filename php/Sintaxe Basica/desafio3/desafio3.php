<?php
$nomes = ["Edvan", "Natan", "Pedro", "Gabriel", "ChatGPT"];

function existeNome($array, $busca){
    $indice = 0;


    while($indice <= count($array)){
        
        if ($busca == $array[$indice]){
            return "nome foi encontrado";

        } else if($busca !== $array[$indice] && $indice >= count($array)){
            return "nome não foi encontrado";

        } else { 
            $indice++;
        }
        
    }
    
}

$nomeProcura = "Edvan";
echo "O ". existeNome($nomes, $nomeProcura);
?>