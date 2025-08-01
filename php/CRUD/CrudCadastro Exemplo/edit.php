<?php
require 'conexao.php';
require 'bootstrap.php';

if (!isset($_GET['id'])) {
    echo "ID não informado!";
    exit;
}

$id = (int) $_GET['id'];

// Se o formulário foi enviado, atualiza o usuário
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $nome = mysqli_real_escape_string($conexao, trim($_POST['nome']));
    $email = mysqli_real_escape_string($conexao, trim($_POST['email']));

    $sql = "UPDATE usuarios SET nome = '$nome', email = '$email' WHERE id = $id";

    if (mysqli_query($conexao, $sql)) {
        header('Location: index.php');
        exit;
    } else {
        echo "Erro ao atualizar: " . mysqli_error($conexao);
    }
}

// Se não enviou o formulário, busca os dados atuais para preencher o form
$sql = "SELECT * FROM usuarios WHERE id = $id LIMIT 1";
$resultado = mysqli_query($conexao, $sql);

if (mysqli_num_rows($resultado) == 0) {
    echo "Usuário não encontrado!";
    exit;
}

$usuario = mysqli_fetch_assoc($resultado);
?>

<!doctype html>
<html lang="pt-br">
<head>
    <meta charset="utf-8">
    <title>Editar Usuário</title>
</head>
<body>
<div class="container mt-4">
    <h1>Editar Usuário</h1>
    <form method="POST">
        <div class="mb-3">
            <label>Nome</label>
            <input type="text" name="nome" class="form-control" value="<?= htmlspecialchars($usuario['nome']) ?>" required>
        </div>
        <div class="mb-3">
            <label>Email</label>
            <input type="email" name="email" class="form-control" value="<?= htmlspecialchars($usuario['email']) ?>" required>
        </div>
        <button type="submit" class="btn btn-primary">Salvar</button>
        <a href="index.php" class="btn btn-secondary">Cancelar</a>
    </form>
</div>
</body>
</html>
