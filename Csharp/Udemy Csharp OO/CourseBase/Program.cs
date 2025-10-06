using System.Globalization;
using System.IO.Pipes;
using System.Text.RegularExpressions;

// Console.Write("Quantos números inteiros você vai digitar? ");
// int N = int.Parse(Console.ReadLine());

// int soma = 0;

// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine("Valor #{0}: ", i);
//     int valor = int.Parse(Console.ReadLine());
//     soma += valor;
// }

// Console.WriteLine("Soma = " + soma);

// Console.Write("Digite um número: ");
// double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// while (x >= 0.0)
// {
//     double raiz = Math.Sqrt(x);
//     Console.WriteLine(raiz.ToString("F3"), CultureInfo.InvariantCulture);
//     Console.Write("Digite um número: ");
//     x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// }

// Console.WriteLine("Número negativo");


// Console.WriteLine("Digite três números:");
// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());

// double resultado = Maior(n1, n2, n3);

// Console.WriteLine("Maior = " + resultado);

// static int Maior(int a, int b, int c)
// {
//     int m;
//     if (a > b && a > c)
//     {
//         m = a;
//     }
//     else if (b > c)
//     {
//         m = b;
//     }
//     else
//     {
//         m = c;
//     }
//     return m;
// }

// if (n1 > n2 && n1 > n3)
// {
//     Console.WriteLine("Maior = " + n1);
// }
// else if (n2 > n3)
// {
//     Console.WriteLine("Maior = " + n2);
// }
// else
// {
//     Console.WriteLine("Maior = " + n3);
// }

// double preco = double.Parse(Console.ReadLine());
// double desconto = 0.0;

// if (preco > 100.0)
// {
//     desconto = preco * 0.1;
// }

// Console.WriteLine(desconto);

// Console.WriteLine("Qual a hora atual?");
// int hora = int.Parse(Console.ReadLine());

// if (hora < 12)
// {
//     Console.WriteLine("Bom dia!");
// }
// else if (hora < 18)
// {
//     Console.WriteLine("Boa tarde");
// }
// else
// {
//     Console.WriteLine("Boa noite");
// }

// Console.WriteLine("Qual a hora atual?");
// int hora = int.Parse(Console.ReadLine());

// if (hora < 12)
// {
//     Console.WriteLine("Bom dia!");
// }

// if (hora >= 12 && hora < 18)
// {
//     Console.WriteLine("Boa tarde");
// }

// if (hora >= 18)
// {
//     Console.WriteLine("Boa noite");
// }

// Console.WriteLine("Entre com um número inteiro: ");
// int x = int.Parse(Console.ReadLine());

// if (x % 2 == 0)
// {
//     Console.WriteLine("Par!");
// }
// else
// {
//     Console.WriteLine("Impar!");
// }

// bool c1 = 2 > 3 && 4 != 5;
// bool c2 = 2 > 3 || 4 != 5;
// bool c3 = !(2 > 3) && 4 != 5;

// Console.WriteLine(c1);
// Console.WriteLine(c2);
// Console.WriteLine(c3);
// Console.WriteLine("-------------------");

// bool c4 = 10 < 5;

// bool c5 = c2 || c3 && c4;

// Console.WriteLine(c4);
// Console.WriteLine(c5);

// int a = 10;
// bool c1 = a < 10;
// bool c2 = a < 20;
// bool c3 = a > 10;
// bool c4 = a > 5;

// Console.WriteLine(c1);
// Console.WriteLine(c2);
// Console.WriteLine(c3);
// Console.WriteLine(c4);
// Console.WriteLine("-------------------------------");

// bool c5 = a <= 10;
// bool c6 = a >= 10;
// bool c7 = a == 10;
// bool c8 = a != 10;

// Console.WriteLine(c5);
// Console.WriteLine(c6);
// Console.WriteLine(c7);
// Console.WriteLine(c8);


//--------------------------    Exercicio   -----------------------------


// Console.WriteLine("Entre com seu nome completo:");
// string nome = Console.ReadLine();
// Console.WriteLine("Quantos quartos tem na sua casa?");
// int quantidadeQuartos = int.Parse(Console.ReadLine());
// Console.WriteLine("Entre com o preço de um produto:");
// double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");

// string[] array = Console.ReadLine().Split(' ');
// string arrayNome = array[0];
// string arrayIdade = array[1];
// string arrayAltura = array[2];

// Console.WriteLine(nome);
// Console.WriteLine(quantidadeQuartos);
// Console.WriteLine(valorProduto);
// Console.WriteLine(arrayNome);
// Console.WriteLine(arrayIdade);
// Console.WriteLine(arrayAltura);


//-----------------------------------------------------------------------


// int n1 = int.Parse(Console.ReadLine());
// char ch = char.Parse(Console.ReadLine());
// double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// string[] vet = Console.ReadLine().Split(' ');
// string nome = vet[0];
// char sexo = char.Parse(vet[1]);
// int idade = int.Parse(vet[2]);
// double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

// Console.WriteLine("Você digitou:");
// Console.WriteLine(n1);
// Console.WriteLine(ch);
// Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
// Console.WriteLine(nome);
// Console.WriteLine(sexo);
// Console.WriteLine(idade);
// Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

// string frase = Console.ReadLine();
// string x = Console.ReadLine();
// string y = Console.ReadLine();
// string z = Console.ReadLine();
// // string s = Console.ReadLine();

// string[] v = Console.ReadLine().Split(' ');
// string a = v[0];
// string b = v[1];
// string c = v[2];

// Console.WriteLine("Você digitou: ");
// Console.WriteLine(frase);
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// int n1 = 3 + 4 * 2;
// int n2 = (3 + 4) * 2;
// int n3 = 17 % 3;
// double n4 = 10.0 / 8.0;

// double a = 1.0, b = -3.0, c = -4.0;

// double delta = Math.Pow(b, 2.0) - 4 * a * c;

// double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
// double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

// Console.WriteLine(n1);
// Console.WriteLine(n2);
// Console.WriteLine(n3);
// Console.WriteLine(n4);
// Console.WriteLine(delta);
// Console.WriteLine(x1);
// Console.WriteLine(x2);

// int a = 5;
// int b = 2;

// double resultado =(double) a / b;

// Console.WriteLine(resultado);

// double a;
// int b;

// a = 5.1;
// b = (int)a;

// Console.WriteLine(b);

// float x = 4.5f;

// double y = x;

// Console.WriteLine(y);

// int a = 10;
// int b = ++a;
// Console.WriteLine(a);
// Console.WriteLine(b);

// int a = 10;
// Console.WriteLine(a);

// a += 2;
// Console.WriteLine(a);

// a *= 3;
// Console.WriteLine(a);

// string s = "ABC";
// Console.WriteLine(s);

// s += "DEF";
// Console.WriteLine(s);


//--------------------------    Exercicio   -----------------------------


// string produto1 = "Computador";
// string produto2 = "Mesa de escritório";

// byte idade = 30;
// int codigo = 5290;
// char genero = 'M';

// double preco1 = 2100.0;
// double preco2 = 650.50;
// double media = 53.234567;

// Console.WriteLine("Produtos:");
// Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
// Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
// Console.WriteLine();
// Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} é gênero: {genero}");
// Console.WriteLine();
// Console.WriteLine("Medida com oito casa decimais: " + media.ToString("F8"));
// Console.WriteLine("Arredondando (três casas decimais): " + media.ToString("F3"));
// Console.WriteLine("Separador decimal invariant culture " + media.ToString("F3", CultureInfo.InvariantCulture));


//-----------------------------------------------------------------------

// int idade = 32;
// double saldo = 10.35784;
// string nome = "Maria";

// Console.WriteLine("{0} tem {1} anos e tem salgo igual a {2:F2} reais", nome, idade, saldo);

// Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

// Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais");

// char genero = 'F';
// int idade = 32;
// double saldo = 10.35784;
// string nome = "Maria";

// Console.Write("Bom dia!");
// Console.WriteLine("Boa tarde!");
// Console.WriteLine("Boa noite!");
// Console.WriteLine("------------------------------------");
// Console.WriteLine(genero);
// Console.WriteLine(idade);
// Console.WriteLine(saldo);
// Console.WriteLine(nome);
// Console.WriteLine(saldo.ToString("F2"));
// Console.WriteLine(saldo.ToString("F4"));
// Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));

// int n1 = int.MinValue;
// int n2 = int.MaxValue;
// sbyte n3 = sbyte.MinValue;
// decimal n4 = decimal.MaxValue;

// System.Console.WriteLine(n1);
// System.Console.WriteLine(n2);
// System.Console.WriteLine(n3);
// System.Console.WriteLine(n4);

// bool completo = false;
// char genero = 'F';
// char letra = '\u0041';
// byte n1 = 126;
// int n2 = 1000;
// int n3 = 2147483647;
// long n4 = 2147483648L;
// float n5 = 4.5f;
// double n6 = 4.5;
// string nome = "Maria Green";
// object obj1 = "Alex Brown";
// object obj2 = 4.5f;

// System.Console.WriteLine(completo);
// System.Console.WriteLine(genero);
// System.Console.WriteLine(letra);
// System.Console.WriteLine(n1);
// System.Console.WriteLine(n2);
// System.Console.WriteLine(n3);
// System.Console.WriteLine(n4);
// System.Console.WriteLine(n5);
// System.Console.WriteLine(n6);
// System.Console.WriteLine(nome);
// System.Console.WriteLine(obj1);
// System.Console.WriteLine(obj2);
