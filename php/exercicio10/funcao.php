<?php



function calculaMedia($nota1, $nota2, $nota3){
    return ($nota1 + $nota2 + $nota3) / 3;
}

$media = calculaMedia(5,5,5);

if($media >= 7){
    echo "Aprovado";
} else if ($media >= 5 && $media < 7){
    echo "Recuperação";
} else {
    echo "Reprovado";
}

?>