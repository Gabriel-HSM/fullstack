using System.Globalization;
using Ex1.Model;

Console.Write("Enter full file path: ");
string path = Console.ReadLine()!;

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine()!.Split(',');
        string name = fields[0];
        string email = fields[1];
        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(name, email, salary));
    }
}

Console.Write("Enter salary: ");
double salaryImput = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.WriteLine("Email of people whose salary is more than " + salaryImput.ToString("F2", CultureInfo.InvariantCulture));

var orderAlf = employees.Where(e => e.Salary > salaryImput).Select(e => e.Email).Order();
foreach (var o in orderAlf)
{
    Console.WriteLine(o);
}

var sumSalary = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
Console.WriteLine("Sum of salary people whose name stars with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));