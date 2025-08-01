<?php

$vetor = [5, 7, 9, 4, 6, 10];

function menorNumero($array){
    $menor = $array[0];

    foreach($array as $index => $numero){

        if($menor < $numero && $index >= count($array)){
            return $menor;

        } else if($menor > $numero){
            $menor = $numero;
        }
    }

    return $menor;
}
    
echo "O menor número é: ". menorNumero($vetor);
?>