<?php
$numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];


function filtrarPares($array){
    $pares;
    $impares;

    foreach($array as $index0 => $numero){

        if($numero % 2 == 0){
            $pares[] = $numero; 
        } else {
            $impares[] = $numero;
        }
    }

    return $pares;
}



foreach(filtrarPares($numeros) as $index1 => $itens){
    echo "$itens<br>";
}

?>