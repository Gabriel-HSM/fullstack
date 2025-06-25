<?php
$numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

function somarImpares($array){
    $par = 0;
    $impar = 0;
    
    foreach($array as $index => $numero){
        if($numero % 2 == 0){
         $par = $par + $numero;
        } else {
         $impar = $impar + $numero;
        }
    }

  return $impar;
}

echo somarImpares($numeros);


?>