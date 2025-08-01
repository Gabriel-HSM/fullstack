<?php

require "../requires/bootstrap.php";
require "../requires/footer.php";
require "../requires/conexao.php";

$query = mysqli_query($conexao, 'SELECT * FROM categorias ORDER BY id DESC');

?>

<!doctype html>
<html lang="pt-br">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Crud Produtos!</title>
  </head>
  
  <body >
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">  
     <!-- <img class="ms-3" src="../imagens/caixa-nav.png" alt="caixa aberta vazia" width="50" height="50">-->

        <div class="container-fluid">
          <h1 style="color:White;">Categorias</h1>

    <nav class="navbar navbar-expand-lg bg-body-tertiary">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" aria-current="page" href="../produto/produtoindex.php">Produtos</a>
        </li>
        <li class="nav-item">
          <a class="nav-link active" aria-current="page">Categorias</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="../index.php">Inicio</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Pricing</a>
        </li>
        <li class="nav-item dropdown">
        </li>
      </ul>
    </div>

</nav> 
</nav>



<div class="container mt-2">
    <table class="table text-center table-striped">
  <thead>

  <!--Colunas--> 
  <a class="btn btn-success btn-lg mb-2" href="../criar/criarCategoria.php">CRIAR CATEGORIA</a>

    <tr>
      <th scope="col">ID</th>
      <th scope="col">NOME</th>
      <th scope="col">AÇÕES</th>
    </tr>
  </thead>

  <!--Linhas-->
  <?php while ($linha = mysqli_fetch_assoc($query)) {?>

  <tbody>
    <tr>
      <th><?=$linha['id']?></th>
      <td><?=$linha['categoria']?></td>
      <td>
        <a class="btn btn-primary btn-sm" href="../editar/editarCategoria.php?id=<?= $linha['id'] ?>">Editar</a>
        <a class="btn btn-danger btn-sm" href="../excluir/excluirCategoria.php?id=<?= $linha['id'] ?>">Excluir</a>

      </td>
    </tr>
  </tbody>
  <?php } ?>
</table>
</div>