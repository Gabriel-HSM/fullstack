<?php 

//conexão arquivo necessário pra conectar ao banco de dados, as variáveis abaixo guardam informações principais para essa conexão porém quem de fato faz isso é o mysqli_connect.



$servidor = 'localhost';
$usuario = 'root';
$senha = 'admin';
$banco = 'crud_simples';

//mysqli_connect é uma função responsável pela conexão com o banco, ele utiliza as varíaveis guardadadas para se conectar com o banco de dados. Os parâmetros são: (localhost, usuario, senha, meubanco) 

$conexao = mysqli_connect($servidor, $usuario, $senha, $banco);

if (!$conexao){
    die('ERRO na conexão'. mysqli_connect_error());
}


?>