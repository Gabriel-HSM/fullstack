<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario Completo</title>
    <style>
        form{
            display: flex;
            flex-direction: column;
            width: 300px;
            gap: 10px;
            }
    </style>
</head>
<body>
    <form action="resposta_completa.php" method="post">

        <h2>Preencha o formulário</h2>

        <input type="text" name="nome" placeholder="Digite seu nome" id="nomeusuario">
        <input type="number" name="idade" placeholder="Digite sua idade" id="idadeusuario">

        <!--Circulo de opções-->

        <div class="radio-item">
            <input type="radio" name="genero" value="masculino"> Masculino
            <input type="radio" name="genero" value="feminino"> Feminino
            <input type="radio" name="genero" value="outro"> Outro
        </div>

         <!--Checkboxes-->

        <div class="checkbox-item">
            <input type="checkbox" name="interesses[]" value="Esporte"> Esportes
            <input type="checkbox" name="interesses[]" value="Musica"> Música
            <input type="checkbox" name="interesses[]" value="Tecnologia"> Tecnologia
        </div>

        <select name="cidade"> 
            <option value="Cidade">Cidade</option>
            <option value="Salvador">Salvador</option>
            <option value="São Paulo">São Paulo</option>
            <option value="Rio de Janeiro">Rio de Janeiro</option>


        </select>

        <input type="submit" value="Enviar">


    </form>
    
</body>
</html>