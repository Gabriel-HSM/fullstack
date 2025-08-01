<?php

$numeros = [10, 5, 8, 11, 19, 7, 35, 20, 5 ,18];

function contarMaioresQueDez($array){

    foreach($array as $index => $numero){
        if($numero < 10){
            $menor[] = $numero;
        } else {
            $maior[] = $numero;
        }
    }
    return count($maior);
}

echo "Quantidade de números maiores que 10: ". contarMaioresQueDez($numeros);

?>