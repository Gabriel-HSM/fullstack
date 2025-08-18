using Exercicio1.Common.models;

int[] inteirosArray = new int[3];

inteirosArray[0] = 72;
inteirosArray[1] = 64;
inteirosArray[2] = 50;

System.Console.WriteLine("Percorrendo com for");
for (int contador = 0; contador < inteirosArray.Length; contador++)
{
    System.Console.WriteLine($"Posição {contador} = {inteirosArray[contador]}");
}

System.Console.WriteLine("Percorrendo com foreach");
foreach (int valor in inteirosArray)
{
    System.Console.WriteLine($"Valor = {valor}");
}




// int numero = 5;

// while (numero < 10)
// {
//     System.Console.WriteLine(numero);
//     numero++;
// }





















// int numero = 5
// for(int contador = 0; contador < 10; contador++)
// {
//     System.Console.WriteLine($"{contador} x {numero} = {contador * numero}");
// }

// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);




















// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// calc.Potencia(3, 3);

// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);







// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade a ser comprada: {quantidadeCompra}");
// Console.WriteLine($"Venda possível: {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, Não temos a quantidade desejada em estoque");
// }




// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);







//cast - casting
//int a = convert.ToInt32("5");
//int a = int.Parse("5");

//int a = convert.ToInt32("null");
//int a = int.Parse("null");

//Console.WriteLine(a);










// int a = 10;
// int b = 20;
// int c = a + b;

//c = c + 5; //30 + 5
// c += 5;

// Console.WriteLine(c);



// DateTime dataAtual = DateTime.Now.AddDays(5);
// System.Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));








// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Valor da variável quantidade {quantidade}");
// Console.WriteLine("Valor da variável altura " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço " + preco);
// Console.WriteLine("Valor da variável condição " + condicao);





//Pessoa p = new Pessoa();

//p.Nome = "Gabriel";
//p.Idade = 26;
//p.Apresentar();