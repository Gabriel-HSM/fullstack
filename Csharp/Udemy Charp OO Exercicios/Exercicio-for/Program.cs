using System.Globalization;


//----------------------- Exercicio 1 --------------------------------


// Console.Write("Digite um valor inteiro: ");
// int x = int.Parse(Console.ReadLine());

// for (int c = 1; c <= x; c++)
// {
//     if (c % 2 != 0)
//     {
//         int impar = c;
//         Console.WriteLine(impar);
//     }
// }


//--------------------------------------------------------------------

//----------------------- Exercicio 2 --------------------------------


// Console.Write("Digite um valor inteiro: ");
// int N = int.Parse(Console.ReadLine());

// int contIn = 0;
// int contOut = 0;

// for (int i = 0; i < N; i++)
// {
//     int x = int.Parse(Console.ReadLine());
//     if (x >= 10 && x <= 20)
//     {
//         contIn = contIn + 1;
//     }
//     else
//     {
//         contOut = contOut + 1;
//     }

//     Console.WriteLine(contIn + " in");
//     Console.WriteLine(contOut + " out");
// }


//--------------------------------------------------------------------

//----------------------- Exercicio 3 --------------------------------

// Console.Write("Digite a quantidade de casos: ");
// int quantidadeCaso = int.Parse(Console.ReadLine());

// for (int C = 0; C < quantidadeCaso; C++)
// {
//     string[] caso = Console.ReadLine().Split(" ");
//     double a = double.Parse(caso[0], CultureInfo.InvariantCulture);
//     double b = double.Parse(caso[1], CultureInfo.InvariantCulture);
//     double c = double.Parse(caso[2], CultureInfo.InvariantCulture);

//     double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;

//     Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

// }


//--------------------------------------------------------------------
//----------------------- Exercicio 4 --------------------------------


// Console.Write("Digite a quantidade de calculos: ");
// int N = int.Parse(Console.ReadLine());


// for (int contador = 0; contador < N; contador++)
// {
//     string[] numeros = Console.ReadLine().Split(" ");
//     double numA = double.Parse(numeros[0], CultureInfo.InstalledUICulture);
//     double numB = double.Parse(numeros[1], CultureInfo.InstalledUICulture);

//     if (numA == 0 || numB == 0)
//     {
//         Console.WriteLine("divisão impossível");
//     }
//     else
//     {
//         double resultado = numA / numB;
//         Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
//     }
// }


//--------------------------------------------------------------------
//----------------------- Exercicio 5 --------------------------------


Console.Write("Digite o número que deseja descobrir seu fatorial: ");
int numero = int.Parse(Console.ReadLine());
int resultado = 0;

if (numero == 0)
{
    Console.WriteLine('1');
}
else if (numero == 1)
{
    Console.WriteLine('1');
}
else
{
    for (int contador = 1; contador < numero; contador++)
    {
        resultado += numero * (numero - contador);
    }
        Console.WriteLine(resultado);
}



//--------------------------------------------------------------------
//----------------------- Exercicio 3 --------------------------------

//--------------------------------------------------------------------