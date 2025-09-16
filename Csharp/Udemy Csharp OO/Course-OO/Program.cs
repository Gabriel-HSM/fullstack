using System.Globalization;
using Course_OO;

// ------------------------ COM POO E COMPLETO --------------------------


// Produto p = new Produto();

// Console.WriteLine("Entre os dados do produto:");
// Console.Write("Nome: ");
// p.Nome = Console.ReadLine();
// Console.Write("Preço: ");
// p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Console.Write("Quantidade em estoque: ");
// p.Quantidade = int.Parse(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine("Dados do produto: " + p);

// Console.WriteLine();
// Console.Write("Digite o número de produtos a ser adiconado ao estoque: ");
// int qte = int.Parse(Console.ReadLine());
// p.AdicionarProduto(qte);
// Console.WriteLine("Dados atualizados: " + p);

// Console.WriteLine();
// Console.Write("Digite o número de produtos a ser removido ao estoque: ");
//  qte = int.Parse(Console.ReadLine());
// p.RemoverProduto(qte);
// Console.WriteLine("Dados atualizados: " + p);


// ------------------------- COM POO E MÈTODOS --------------------------


// Triangulo x, y;

// x = new Triangulo();
// y = new Triangulo();

// Console.WriteLine("Entre com as medidas do triângulo X: ");
// x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Console.WriteLine("Entre com as medidas do triângulo Y: ");
// y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double areaX = x.Area();

// double areaY = y.Area();

// Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

// Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

// if (areaX > areaY)
// {
//     Console.WriteLine("Maior área: X");
// }
// else
// {
//     Console.WriteLine("Maior área: Y");
// }


// ------------------------------ COM POO -------------------------------


// Triangulo x, y;

// x = new Triangulo();
// y = new Triangulo();

// Console.WriteLine("Entre com as medidas do triângulo X: ");
// x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Console.WriteLine("Entre com as medidas do triângulo Y: ");
// y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double p = (x.A + x.B + x.C) / 2.0;
// double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

// p = (y.A + y.B + y.C) / 2.0;
// double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

// Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

// Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

// if (areaX > areaY)
// {
//     Console.WriteLine("Maior área: X");
// }
// else
// {
//     Console.WriteLine("Maior área: Y");
// }


// ------------------------------ SEM POO -------------------------------


// double xA, xB, xC, yA, yB, yC;

// Console.WriteLine("Entre com as medidas do triângulo X: ");
// xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Console.WriteLine("Entre com as medidas do triângulo Y: ");
// yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double p = (xA + xB + xC) / 2.0;
// double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

// p = (yA + yB + yC) / 2.0;
// double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

// Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

// Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

// if (areaX > areaY)
// {
//     Console.WriteLine("Maior área: X");
// }
// else
// {
//     Console.WriteLine("Maior área: Y");

// }