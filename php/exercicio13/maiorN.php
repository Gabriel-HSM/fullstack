<?php

$numeros = [1, 2 ,10 ,7 ,8 ,5];

function maiorNumero($array){
    $maior = $array[0];

    foreach($array as $numero){
        if($numero > $maior){
            $maior = $numero;
        }
    }

    return $maior;
}

echo "O maior número do array é: " . maiorNumero($numeros);

?>