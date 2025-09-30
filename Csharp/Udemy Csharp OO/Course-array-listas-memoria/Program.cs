using System.Drawing;
using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using Course_array_listas_memoria;
using System.Collections.Generic;


List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Marco");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine("List Count: " + list.Count);

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("FIrst 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A': " + s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A': " + pos2);


List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("------------------------------");
foreach (string obj in list2)
{
    Console.WriteLine(obj);
}

list.Remove("Alexx");
Console.WriteLine("------------------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("------------------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}


// Console.WriteLine("First 'A': " + s1);

// static bool Test(string s)
// {
//     return s[0] == 'A';
// }


// List<string> list = new List<string>();

// List<string> list2 = new List<string> { "Maria", "Alex" };


// string[] vect = new string[] { "Maria", "Alex", "Bob" };

// for (int i = 0; i < vect.Length; i++) {
//     Console.WriteLine(vect[i]);
// }

// Console.WriteLine("----------------------------");

// foreach (string objeto in vect)
// {
//     Console.WriteLine(objeto);
// }

//-----------------------------------------------------------------------


// int a = 10;
// int triple;
// Calculator.Triple(a, out triple);
// Console.WriteLine(a);
// Console.WriteLine(triple); 

//-------------------------------------------------------------------------


// int[] testeNumeros = new int[4];
// testeNumeros[0] = 2;
// testeNumeros[1] = 3;


// int[] testeDireto = new int[] { 2, 4, 3};

// int s1 = Calculator.Sum( 2, 3 );
// int s2 = Calculator.Sum(2, 4, 3 );
// int s3 = Calculator.Sum(testeNumeros);
// int s4 = Calculator.Sum(testeDireto);

// Console.WriteLine(s1);
// Console.WriteLine(s2);
// Console.WriteLine(s3);
// Console.WriteLine(s4);

// int n = int.Parse(Console.ReadLine());

// Product[] vect = new Product[n];

// for (int i = 0; i < n; i++)
// {
//     string name = Console.ReadLine();
//     double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//     vect[i] = new Product { Name = name, Price = price };
// }

// double sum = 0.0;
// for (int i = 0; i < n; i++)
// {
//     sum += vect[i].Price;
// }
// double avg = sum / n;

// Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InstalledUICulture));


// int n = int.Parse(Console.ReadLine());

// double[] vect = new double[n];

// for (int i = 0; i < n; i++)
// {
//     vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// }

// double sum = 0.0;
// for (int i = 0; i < n; i++)
// {
//     sum += vect[i];
// }

// double avg = sum / n;

// Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));


// double? x = null;
// double? y = 10;

// double a = x ?? 5;
// double b = y ?? 5;

// Console.WriteLine(a);
// Console.WriteLine(b);


// double? x = null;
// double? y = 10.0;

// Console.WriteLine(x.GetValueOrDefault());
// Console.WriteLine(y.GetValueOrDefault());

// Console.WriteLine(x.HasValue);
// Console.WriteLine(y.HasValue);

// if (x.HasValue)
// {
//     Console.WriteLine(x.Value);
// }
// else
// {
//     Console.WriteLine("X is null");
// }

// if (y.HasValue)
// {

//     Console.WriteLine(y.Value);
// }
// else
// {
//     Console.WriteLine("Y is null");
// }