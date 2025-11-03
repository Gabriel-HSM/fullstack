using Course_Interface_X_Herança.Model.Entities;
using Course_Interface_X_Herança.Model.Enums;

IShape s1 = new Circle(){ Radius = 2.0, Color = Colors.white};
IShape s2 = new Retangle() { Width = 3.5, Height = 4.2, Color = Colors.Black };

Console.WriteLine(s1);
Console.WriteLine(s2);