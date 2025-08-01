<?php

require "conexao.php";
require "bootstrap.php";

if(isset($_GET['id'])){

    
     // cast para int para segurança
    $id = (int) $_GET['id'];

    //Comando que deleta, porém com o id selecionado
    $sql = "DELETE FROM usuarios WHERE id = $id";

    if (mysqli_query($conexao, $sql)){
        header('Location: index.php');
    } else {
        echo "Erro ao deletar" . mysqli_error($conexao);
    }

} else {
    echo "ID não informado!";
}



?> 

