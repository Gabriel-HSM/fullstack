using System.Globalization;

//------------------------    Exercicio 1   -----------------------------


// Console.WriteLine("Digite um número inteiro: ");
// int num = int.Parse(Console.ReadLine());

// if (num < 0)
// {
//     Console.WriteLine("NEGATIVO");
// }
// else
// {
//     Console.WriteLine("NÃO NEGATIVO");
// }


//-----------------------------------------------------------------------

//------------------------    Exercicio 2   -----------------------------


// Console.WriteLine("Digite um número inteiro: ");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("PAR");
// }
// else
// {
//     Console.WriteLine("IMPAR");
// }


//-----------------------------------------------------------------------

//------------------------    Exercicio 3   -----------------------------


// Console.WriteLine("Digite dois numero inteiros:");
// string[] numerosInteiros = Console.ReadLine().Split(' ');

// int A = int.Parse(numerosInteiros[0]);
// int B = int.Parse(numerosInteiros[1]);

// if (A % B == 0 || B % A == 0)
// {
//     Console.WriteLine("São Multiplos");
// }
// else
// {
//     Console.WriteLine("Não são Multiplos");
// }


//-----------------------------------------------------------------------

//------------------------    Exercicio 4   -----------------------------


// Console.WriteLine("Digite a hora inicial e a hora final:");
// string[] entradaHoras = Console.ReadLine().Split(' ');

// int horaInicial = int.Parse(entradaHoras[0]);
// int horaFinal = int.Parse(entradaHoras[1]);

// int horaLimite = 24;
// int duracao = 0;

// if (horaInicial > horaFinal)
// {
//     duracao = horaLimite - horaInicial + horaFinal;
//     Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
// }
// else if (horaInicial == horaFinal)
// {
//     duracao = horaLimite;
//     Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
// }
// else if (horaInicial < horaFinal)
// {
//     duracao = horaFinal - horaInicial;
//     Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
// }

// //MÉTODO USADO PELO PROFESSOR

// // Console.WriteLine("Digite a hora inicial e a hora final:");
// // string[] entradaHoras = Console.ReadLine().Split(' ');

// // int horaInicial = int.Parse(entradaHoras[0]);
// // int horaFinal = int.Parse(entradaHoras[1]);

// // int duracao = 0;

// // if (horaInicial < horaFinal)
// // {
// //     duracao = horaFinal - horaInicial;
// //     Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
// // }
// // else if (horaInicial > horaFinal)
// // {
// //    duracao = 24 - horaInicial - horaFinal;
// //     Console.WriteLine($"O JOGO DUROU {duracao} HORAS(S)");
// // }


//-----------------------------------------------------------------------

//------------------------    Exercicio 5   -----------------------------


// Console.WriteLine("Digite o código do item, e sua quantidade: (mesma linha)");
// Console.WriteLine(" 1 -- Cachorro Quente -- R$ 4.00");
// Console.WriteLine(" 2 ------ X-salada ----- R$ 4.50");
// Console.WriteLine(" 3 ------ X-Bacon ------ R$ 5.00");
// Console.WriteLine(" 4 -- Torrada simples -- R$ 2.00");
// Console.WriteLine(" 5 ---- Refrigerante --- R$ 1.50");

// string[] itens = Console.ReadLine().Split(' ');

// int id = int.Parse(itens[0]);
// int quantidade = int.Parse(itens[1]);
// double preco = 0.00;

// if (id == 1)
// {
//     preco = 4.00 * quantidade;
// }
// else if (id == 2)
// {
//     preco = 4.50 * quantidade;
// }
// else if (id == 3)
// {
//     preco = 5.00 * quantidade;
// }
// else if (id == 4)
// {
//     preco = 2.00 * quantidade;
// }
// else
// {
//     preco = 1.50 * quantidade;
// }

// Console.WriteLine("Total: R$ " + preco.ToString("F2"));


//-----------------------------------------------------------------------

//------------------------    Exercicio 6   -----------------------------


// Console.WriteLine("Digite  o valor:");
// double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// if (valor > 0 && valor <= 25)
// {
//     Console.WriteLine("Intervalor [0, 25]");
// }
// else if (valor > 25 && valor <= 50)
// {
//     Console.WriteLine("Intervalor [25, 50]");
// }
// else if (valor > 50 && valor <= 75)
// {
//     Console.WriteLine("Intervalor [50, 75]");
// }
// else if (valor > 75 && valor <= 100)
// {
//     Console.WriteLine("Intervalor [75, 100]");
// }
// else
// {
//     Console.WriteLine("Fora de intervalo");
// }


//-----------------------------------------------------------------------

//------------------------    Exercicio 7   -----------------------------


// Console.WriteLine("Digite os dois valores na mesma linha");
// string[] xy = Console.ReadLine().Split(' ');

// double x = double.Parse(xy[0], CultureInfo.InvariantCulture);
// double y = double.Parse(xy[1], CultureInfo.InvariantCulture);

// if (x == 0 && y == 0)
// {
//     Console.WriteLine("Origem");
// }
// else if (x > 0 && y > 0)
// {
//     Console.WriteLine("Q1");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Q4");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Q2");
// }
// else
// {
//     Console.WriteLine("Q3");
// }


//-----------------------------------------------------------------------

//------------------------    Exercicio 8   -----------------------------





//-----------------------------------------------------------------------