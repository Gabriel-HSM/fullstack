using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using Course_OO;

// DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

// DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

// DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

// Console.WriteLine("d1: " + d1);
// Console.WriteLine("d1 Kind: " + d1.Kind);
// Console.WriteLine("d1 to Local " + d1.ToLocalTime());
// Console.WriteLine("d1 to Utc " + d1.ToUniversalTime());


// TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

// Console.WriteLine(t);

// Console.WriteLine("Days: " + t.Days);

// TimeSpan t1 = TimeSpan.MaxValue;
// TimeSpan t2 = TimeSpan.MinValue;
// TimeSpan t3 = TimeSpan.Zero;

// Console.WriteLine(t1);
// Console.WriteLine(t2);
// Console.WriteLine(t3);

// DateTime d = new DateTime(2025, 10, 02, 12, 00, 53);

// DateTime d2 = d.AddHours(2);
// DateTime d3 = d.AddMinutes(3);

// Console.WriteLine(d);
// Console.WriteLine(d2);
// Console.WriteLine(d3);


// DateTime d = new DateTime(2025, 10, 02, 12, 00, 53 );

// string s1 = d.ToLongDateString();
// string s2 = d.ToLongTimeString();
// string s3 = d.ToShortDateString();
// string s4 = d.ToShortTimeString();

// string s5 = d.ToString();

// string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
// string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

// Console.WriteLine(s1);
// Console.WriteLine(s2);
// Console.WriteLine(s3);
// Console.WriteLine(s4);
// Console.WriteLine(s5);
// Console.WriteLine(s6);
// Console.WriteLine(s7);

// TimeSpan t1 = TimeSpan.FromDays(1.5);
// TimeSpan t2 = TimeSpan.FromHours(1.5);
// TimeSpan t3 = TimeSpan.FromMinutes(1.5);
// TimeSpan t4 = TimeSpan.FromSeconds(1.5);
// TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
// TimeSpan t6 = TimeSpan.FromTicks(900000000L);

// Console.WriteLine(t1);
// Console.WriteLine(t2);
// Console.WriteLine(t3);
// Console.WriteLine(t4);
// Console.WriteLine(t5);
// Console.WriteLine(t6);

// TimeSpan t1 = new TimeSpan();
// TimeSpan t2 = new TimeSpan(900000000L);
// TimeSpan t3 = new TimeSpan(2, 11, 21);
// TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
// TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

// Console.WriteLine(t1);
// Console.WriteLine(t2);
// Console.WriteLine(t3);
// Console.WriteLine(t4);
// Console.WriteLine(t5);


// TimeSpan t1 = new TimeSpan(0, 1, 30);

// Console.WriteLine(t1);
// Console.WriteLine(t1.Ticks);

// DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

// DateTime d2 = DateTime.ParseExact("18/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

// Console.WriteLine(d1);
// Console.WriteLine(d2);

// DateTime d1 = DateTime.Parse("2000-08-15");
// DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

// DateTime d3 = DateTime.Parse("15/08/2000");
// DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

// Console.WriteLine(d1);
// Console.WriteLine(d2);
// Console.WriteLine(d3);
// Console.WriteLine(d4);

// DateTime d1 = new DateTime(2025, 10, 25);
// DateTime d2 = DateTime.Now;
// DateTime d3 = DateTime.Today;
// DateTime d4 = DateTime.UtcNow;

// Console.WriteLine(d1);
// Console.WriteLine(d2);
// Console.WriteLine(d3);
// Console.WriteLine(d4);


// string original = "abcde FGHIJ ABC abc DEFG   ";

// string s1 = original.ToUpper();
// string s2 = original.ToLower();
// string s3 = original.Trim();

// int n1 = original.IndexOf("bc");
// int n2 = original.LastIndexOf("bc");

// string s4 = original.Substring(3);
// string s5 = original.Substring(3, 5);

// string s6 = original.Replace('a', 'x');
// string s7 = original.Replace("abc", "xy");

// bool b1 = String.IsNullOrEmpty(original);
// bool b2 = String.IsNullOrWhiteSpace(original);

// Console.WriteLine("Original: -" + original + "-");
// Console.WriteLine("ToUpper: -" + s1 + "-");
// Console.WriteLine("ToLower: -" + s2 + "-");
// Console.WriteLine("Trim: -" + s3 + "-");
// Console.WriteLine("IndexOf('bc'): " + n1);
// Console.WriteLine("LastIndexOf('bc'): " + n2);
// Console.WriteLine("Substring(3): -"+ s4 + "-");
// Console.WriteLine("Substring(3 , 5): -"+ s5 + "-");
// Console.WriteLine("Replace ('a' , 'x'): -"+ s6 + "-");
// Console.WriteLine("Replace ('abc , 'xy'): -"+ s7 + "-");
// Console.WriteLine("IsNullOrEmpty: "+ b1);
// Console.WriteLine("IsNullWhiteSpace: "+ b2);


// double preco = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
// double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

// // if (preco < 20.0)
// // {
// //     desconto = preco * 0.1;
// // }
// // else
// // {
// //     desconto = preco * 0.05;
// // }

// Console.WriteLine(desconto);


// int x = int.Parse(Console.ReadLine());
// string day;

// switch (x)
// {
//     case 1:
//         day = "Sunday";
//         break;

//     case 2:
//         day = "Monday";
//         break;

//     case 3:
//         day = "Tuesday";
//         break;

//     case 4:
//         day = "Wednesday";
//         break;

//     case 5:
//         day = "Thursday";
//         break;

//     case 6:
//         day = "Friday";
//         break;

//     case 7:
//         day = "saturday";
//         break;

//     default:
//         day = "Invalid value";
//         break;
// }

// Console.WriteLine(day);


// var x = 10;
// var y = 20.0;
// var z = "Maria";

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);


// Produto p = new Produto("TV", 500.00, 10);
// p.Nome = "T";

// Console.WriteLine(p.Nome);
// Console.WriteLine(p.Preco);

// Console.WriteLine("Entre os dados do produto:");
// Console.Write("Nome: ");
// string nome = Console.ReadLine();
// Console.Write("Preço: ");
// double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// // Console.Write("Quantidade em estoque: ");
// // int quantidade = int.Parse(Console.ReadLine());

// Produto p = new Produto(nome, preco);
// // Produto p1 = new Produto();
// Produto p3 = new Produto() {
//     Nome = "TV",
//     Preco = 500.00,
//     Quantidade = 20 };

// Console.WriteLine();
// Console.WriteLine("Dados do produto: " + p);

// Console.WriteLine();
// Console.Write("Digite o número de produtos a ser adiconado ao estoque: ");
// int qte = int.Parse(Console.ReadLine());
// p.AdicionarProduto(qte);
// Console.WriteLine("Dados atualizados: " + p);

// Console.WriteLine();
// Console.Write("Digite o número de produtos a ser removido ao estoque: ");
// qte = int.Parse(Console.ReadLine());
// p.RemoverProduto(qte);
// Console.WriteLine("Dados atualizados: " + p);


//------------------------ USANDO BIBLIOTECA ------------------------


// Console.WriteLine("Entre o valor do raio: ");
// double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// double circ = Calculadora.Circunferencia(raio);
// double volume = Calculadora.Volume(raio);

// Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
// Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
// Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


//------------------------ MÉTODOS NA PROPRIA CLASSE ------------------------


// namespace Course {
//     class Program
//     {

//         static double Pi = 3.14;
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Entre o valor do raio: ");
//             double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//             double circ = Circunferencia(raio);
//             double volume = Volume(raio);

//             Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
//             Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//             Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

//         }

//         static double Circunferencia(double r)
//         {
//             return 2.0 * Pi * r;
//         }

//         static double Volume(double r)
//         {
//             return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
//         }
//     }
// }


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