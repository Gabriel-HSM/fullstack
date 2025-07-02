<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Primeiro Formulário</title>


    <style>
         form {
            display: flex;
            flex-direction: column;
            width: 200px;
            gap: 10px;
            }
    </style>
</head>

<body>

    <h2>Digite os dados:</h2>

   <form action="resposta_get.php" method="get">

    <input type="text" name="nomeusuario" id="nomeusuario" class="form" placeholder="Seu nome">
   
    <input type="text" name="idadeusuario" id="idadeusuario" class="form" placeholder="Sua idade">
    
    <input type="text" name="cidadeusuario" id="cidadeusuario" class="form" placeholder="Sua cidade">
    
    <input type="submit" value="Enviar">

</body>
</html>