<?php

$nome = $_POST["nome"];
$idade = $_POST["idade"];
$genero = $_POST["genero"];
$cidade = $_POST["cidade"];
$interesses = $_POST["interesses"];



echo "Olá $nome você tem $idade anos, é do gênero $genero mora em $cidade e se interessa por: <br>";

foreach($interesses as $interesse){
        echo "-$interesse<br>";
    }

?>