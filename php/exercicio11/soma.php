<?php
$numeros = [2, 4, 6, 10, 7, 5];

function somarArray($arr){
    $soma = 0;

    foreach($arr as $index){
        $soma = $soma + $index;
    }
    return $soma;
}

echo "A soma do vetor é de: ". somarArray($numeros);

?>