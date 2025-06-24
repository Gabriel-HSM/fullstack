<?php

$num1 = 10;
$num2 = 2;
$resultado;
$operacao = "multiplicacao";

    switch($operacao){
    case "soma":
    echo $resultado = $num1 + $num2;
    break;

    case "subtracao":
    echo $resultado = $num1 - $num2;
    break;

    case "divisao":
    echo $resultado = $num1 / $num2;
    break;

    case "multiplicacao":
    echo $resultado = $num1 * $num2;
    break;

    default:
    echo "Impossível fazer operação, observe se digitou sem acentos e de forma correta";
    break;
}


?>