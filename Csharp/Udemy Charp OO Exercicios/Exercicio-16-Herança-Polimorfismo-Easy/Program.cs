using System.Globalization;
using Exercicio_16_Herança_Polimorfismo1.Entities;

Console.Write("Enter the number of employees: ");
int quantityEmployees = int.Parse(Console.ReadLine());
List<Employee> employees = new List<Employee>();

for (int i = 1; i <= quantityEmployees; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsorced (y/n)? ");
    char Outsorced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string employeeName = Console.ReadLine();
    Console.Write("Hours ");
    int employeeHours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (Outsorced == 'y' || Outsorced == 'Y')
    {
        Console.Write("Additional charge: ");
        double additionalChange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        employees.Add(new OutSourceEmployee(employeeName, employeeHours, valuePerHour, additionalChange));
    }
    else
    {
        employees.Add(new Employee(employeeName, employeeHours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS");
foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)} ");
}
