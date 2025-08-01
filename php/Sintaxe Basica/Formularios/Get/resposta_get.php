<?php

    $nome = $_GET["nomeusuario"];
    $idade = $_GET["idadeusuario"];
    $cidade = $_GET["cidadeusuario"];

    if(empty($nome)){
        echo "Por favor coloque seu nome!";
    } else if(empty($idade)){
        echo "Por favor coloque sua idade!";
    } else if(empty($cidade)){
        echo "Por favor coloque sua cidade!";
    } else {
        echo "Olá, $nome! Você tem $idade anos e mora em $cidade";
    }


    ?>