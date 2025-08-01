<?php 

require 'conexao.php';

$lista = mysqli_query($conexao, 'SELECT * FROM usuarios ORDER BY id DESC');

?>

<!doctype html>
<html lang="py-br">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>CRUD procedual</title>

     <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">


  </head>
  <body>

    <h1>Usuários</h1>
    <a href="create.php" class="btn btn-success">Adicionar novo</a>

    <!-- Inicio da tabela que lista os usuários-->

    <div class="container">
        <table class="table table-striped">


            <!--Definição das colunas-->
            <tr>
                <tr>
                    <th class="form col">ID</th>
                    <th class="form col">Nome</th>
                    <th class="form col">Email</th>
                    <th class="form col">Ações</th>
                </tr>
            </tr>
            <!--Tradução de ROW é linha-->
            <!--mysqli_fetch_assoc($resultado) cria um array e pega linha por linha, então enquanto tiver linha o array vai listar uma por uma-->
            <?php while ($row = mysqli_fetch_assoc($lista)) { ?>
                <tr>
                    <td><?= $row['id'] ?></td>
                    <td><?= $row['nome'] ?></td>
                    <td><?= $row['email'] ?></td>
                    <td>
                        <a class="btn btn-primary" href="edit.php?id=<?= $row['id'] ?>">Editar</a> <!--O ? separa a URL dos dados enviados pois isso é um método get, então entraremos em editar um usuário com um ID aberto com as tags do php-->
                        <a class="btn btn-danger" href="delete.php?id=<?= $row['id'] ?>">Excluir</a>
                    </td>
                </tr>
            <?php } ?>
        </table>
    </div>


  </body>
</html>





