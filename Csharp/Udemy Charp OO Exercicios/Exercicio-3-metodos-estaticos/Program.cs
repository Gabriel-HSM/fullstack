using System.Globalization;
using Exercicio_3_metodos_estaticos;

Console.Write("Qual a cotação do dólar? ");
double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double QuantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double ValorEmReais = CoversorDeMoeda.CalcularTotalDolar(QuantidadeDolar, Cotacao);

Console.Write("Valor a ser pago em raias = " + ValorEmReais.ToString("F2", CultureInfo.InvariantCulture));