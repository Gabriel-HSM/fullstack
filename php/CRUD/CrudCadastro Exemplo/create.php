<?php

require 'conexao.php';
require 'bootstrap.php';

//Se o servidor solicitar o método POST, faça:
if($_SERVER['REQUEST_METHOD'] === 'POST'){

    /*Tem muita infomação mas esses métodos real_scape e trim são usado para segurança, trim para remover espaços iniciais e finais, scape para não ter injeção nos campos. A forma simples de escrever é assim:
  
    $nome = $_POST['nome'] */


    $nome = mysqli_real_escape_string($conexao, trim($_POST['nome']));
    $email = mysqli_real_escape_string($conexao, trim($_POST['email']));

    //precisamos adicionar esses dados coletados no MYSQL

    $sql = "INSERT INTO usuarios (nome, email) VALUES ('$nome', '$email')";

    //Enviar esses dados para o banco! é necessário usar mysql_query(conexao-desejada, instruçãosql)

    if(mysqli_query($conexao, $sql)){
        header('Location: index.php');
        exit;
    } else {
        echo "Erro ao cadastrar: " . mysqli_error($conexao);
    }

}

?>

<!-- Formulário HTML -->
<h1>Novo Usuário</h1>
<form method="POST">

<div class="container">
    <div class="form-group">
        <label>Nome</label>
        <input type="text" class="form-control" name="nome" placeholder="Nome de usuário">
    </div>
    
    <div class="form-group">
        <label for="exampleInputEmail1">Email</label>
        <input type="email" class="form-control" name="email" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Email de usuário">
    </div>
    <button class="btn btn-success mt-4" type="submit">Cadastrar</button>
</div>

</form>