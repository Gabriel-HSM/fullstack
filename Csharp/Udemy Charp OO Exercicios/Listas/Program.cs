﻿using System.Globalization;
using Listas;

Console.Write("How many employees will be registered? ");
int employeerNumber = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for (int i = 1; i <= employeerNumber; i++)
{
    Console.WriteLine($"Employee #{i}: ");

    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine(" ");
    employees.Add(new Employee(id, name, salary));
}

Console.WriteLine("Enter the employee id that will have salary increase: ");
int employeeId = int.Parse(Console.ReadLine());

Employee employeeChosen = employees.Find(x => x.Id == employeeId);
if (employeeChosen != null)
{
    Console.WriteLine("Enter the percent");
    double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employeeChosen.IncreasesSalary(percent);
    
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("Updated list of employees:");
foreach (Employee obj in employees)
{
    Console.WriteLine(obj);
}
