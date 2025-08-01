<?php

$host = 'localhost';
$user = 'root';
$senha = 'admin';
$banco = 'crud_sproduto';

$conexao = mysqli_connect($host, $user, $senha, $banco);

if (!$conexao){
    die ("ERRO ao conectar");
}

?>