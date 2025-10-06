using System.Globalization;

//-------------------------- EXERCICIO 1 -------------------------------


// Console.WriteLine("Escreva o primeiro número");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Escreva o segundo número");
// int num2 = int.Parse(Console.ReadLine());
// int soma = num1 + num2;

// Console.WriteLine($"SOMA = {soma}");


//----------------------------------------------------------------------

//-------------------------- EXERCICIO 2 -------------------------------


// double pi = 3.14159;

// Console.WriteLine("Escreva o valor do raio do círculo");
// double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double area = pi * Math.Pow(raioCirculo, 2);

// Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


//----------------------------------------------------------------------

//-------------------------- EXERCICIO 3 -------------------------------


// Console.WriteLine("Escreva o valor de A");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Escreva o valor de B");
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine("Escreva o valor de C");
// int C= int.Parse(Console.ReadLine());
// Console.WriteLine("Escreva o valor de D");
// int D = int.Parse(Console.ReadLine());

// int diferenca = (A * B) - (C * D);

// Console.WriteLine("Diferença = " + diferenca);


//----------------------------------------------------------------------

//-------------------------- EXERCICIO 4 -------------------------------


// Console.WriteLine("Adicione seu ID:");
// int id = int.Parse(Console.ReadLine());
// Console.WriteLine("Adicione seu número de horas:");
// int horasTrabalhadas = int.Parse(Console.ReadLine());
// Console.WriteLine("Adicione seu valor por hora:");
// double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double salario = horasTrabalhadas * valorPorHora;

// Console.WriteLine("NUMBER = " + id);
// Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));


//----------------------------------------------------------------------

//-------------------------- EXERCICIO 5 -------------------------------


// Console.WriteLine("Digite o código, quantidade e valor unitário da peça 1: (Mesma linha)");
// string[] arrayP1 = Console.ReadLine().Split(' ');

// string codigoP1 = arrayP1[0];
// int quantidadeP1 = int.Parse(arrayP1[1]);
// double valorP1 = double.Parse(arrayP1[2], CultureInfo.InvariantCulture);
// double valorPagarP1 = quantidadeP1 * valorP1;    

// Console.WriteLine("Digite o código, quantidade e valor unitário da peça 2: (Mesma linha)");
// string[] arrayP2 = Console.ReadLine().Split(' ');

// string codigoP2 = arrayP2[0];
// int quantidadeP2 = int.Parse(arrayP2[1]);
// double valorP2 = double.Parse(arrayP2[2], CultureInfo.InvariantCulture);
// double valorPagarP2 =quantidadeP2 * valorP2;

// Console.WriteLine("VALOR A PAGAR: R$ " + (valorPagarP1 + valorPagarP2).ToString("F2"));


//----------------------------------------------------------------------

//-------------------------- EXERCICIO 5 -------------------------------


// Console.WriteLine("Digite os valores de A, B e C: (Mesma Linha)");
// string[] array = Console.ReadLine().Split(' ');

// double A = double.Parse(array[0], CultureInfo.InvariantCulture);
// double B = double.Parse(array[1], CultureInfo.InvariantCulture);
// double C = double.Parse(array[2], CultureInfo.InvariantCulture);
// double pi = 3.14159;

// Console.WriteLine("TRIÂNGULO: " + ((A * C) / 2 ).ToString("F3"));
// Console.WriteLine("CIRCULO: " + (Math.Pow(C,2) * pi).ToString("F3"));
// Console.WriteLine("TRAPEZIO: " + ((A + B) * (C / 2)).ToString("F3"));
// Console.WriteLine("QUADRADO: " + (B * B).ToString("F3"));
// Console.WriteLine("RETANGULO: " + (A * B).ToString("F3"));


//----------------------------------------------------------------------