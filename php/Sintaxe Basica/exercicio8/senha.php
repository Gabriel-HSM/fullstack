<?php

$senhaCorreta = "1234";
$tentativa = "0";

do{
    if($tentativa !== $senhaCorreta){
        echo "Senha inválida! Tente novamente<br>";

        $tentativa = "1234";
        echo "Acesso Permitido";


    } else {
        echo "Acesso Permitido";
    }



}while($senhaCorreta !== $tentativa)

?>