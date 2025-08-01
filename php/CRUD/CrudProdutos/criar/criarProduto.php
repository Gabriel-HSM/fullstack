<?php

require "../requires/conexao.php";
require "../requires/bootstrap.php";

// Consulta de categorias sempre disponível
$sqlCategoria = "SELECT id, categoria FROM categorias";
$resultCategoria = mysqli_query($conexao, $sqlCategoria);

if($_SERVER['REQUEST_METHOD'] === 'POST'){

  $nome = mysqli_real_escape_string($conexao, trim($_POST['nome_produto']));
  $valor = mysqli_real_escape_string($conexao, trim($_POST['valor']));
  $categoria_id = mysqli_real_escape_string($conexao, trim($_POST['categoria_id']));

  $sql = "INSERT INTO produtos (nome, valor, categoria_id) VALUES ('$nome', '$valor', '$categoria_id')";

  if(mysqli_query($conexao, $sql)){
      header('Location: ../produto/produtoindex.php');
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
          <h1 style="color:White;">Criar Produto</h1>

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
        <h2>Nome do Produto</h2>
        <input type="text" class="form-control" name="nome_produto" placeholder="Nome do Produto">
        <h3 class="mt-2">Valor do Produto  </h2>
        <input type="text" class="form-control" name="valor" id="valor" placeholder="Valor do Produto">
        <h3>Categoria do Produto</h2>

        <select name="categoria_id">
          <?php while($linha = mysqli_fetch_assoc($resultCategoria)): ?>
            <option value="<?php echo $linha['id']; ?>"><?php echo $linha['categoria']; ?></option>
            <?php endwhile; ?>
        </select>

        <input class="btn btn-success mt-2" type="submit" value="Criar">
  </form>
</div>
    
<script>
  // Formatação do campo de valor
  document.getElementById('valor').addEventListener('input', function (e) {
      let valor = e.target.value.replace(/\D/g, '');
      valor = (valor / 100).toFixed(2).replace('.', ',');
      e.target.value = 'R$ ' + valor;
  });
</script>
</body>
</html>