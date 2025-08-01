<?php

require "../requires/conexao.php";
require "../requires/bootstrap.php";

if (!isset($_GET['id'])) {
    echo "ID não informado!";
    exit;
}

$id = (int) $_GET['id'];

if($_SERVER['REQUEST_METHOD'] === 'POST'){


  $sql = "DELETE FROM categorias WHERE id = $id";

  if(mysqli_query($conexao, $sql)){
      header('Location: ../categoria/categoriaindex.php');
      exit;
  } else {
      echo "Erro ao cadastrar: " . mysqli_error($conexao);
  }


}



?>

<!DOCTYPE html>
<html lang="ept-brn">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Crud Produtos!</title>
</head>
<body>

<nav class="navbar navbar-expand-lg navbar-dark bg-dark">  
      <!--<img class="ms-3" src="imagens/caixa-nav.png" alt="caixa aberta vazia" width="50" height="50">-->

        <div class="container-fluid">
          <h1 style="color:White;">Excluir Categoria</h1>

    <nav class="navbar navbar-expand-lg bg-body-tertiary">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" aria-current="page" href="../produto/produtoindex.php">Produtos</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" aria-current="page" href="../categoria/categoriaindex.php">Categorias</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="../index.php">Inicio</a>
        </li>

      </ul>
    </div>

</nav>  
</nav>

<div class="container mt-4">
  <form class="mt-1" action="" method="POST">
      <div class="form-group">
        <h2>Excluir</h2>
        <p>Você tem certeza que deseja excluir esta categoria?</p>
        <a class="btn btn-primary mt-2" href="../categoria/categoriaindex.php"> Voltar</a>
        <input class="btn btn-danger mt-2" type="submit" value="Excluir">
  </form>
</div>

    
</body>
</html>