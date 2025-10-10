using System.Globalization;
using Exercicio_19_Abstracts_methods_class.Entities;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
List<TaxPayers> taxPayers = new List<TaxPayers>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or Company (i/c)? ");
    char ic = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ic == 'i')
    {
        Console.Write("Health expendidures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else if (ic == 'c')
    {
        Console.Write("Number of employees: ");
        int employeesNumber = int.Parse(Console.ReadLine());

        taxPayers.Add(new Company(name, anualIncome, employeesNumber));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double totalTaxes = 0;

foreach (TaxPayers payers in taxPayers)
{
    Console.WriteLine(payers.Name + ": $ " + payers.Tax().ToString("F2", CultureInfo.InvariantCulture));
    totalTaxes += payers.Tax();
}

    Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InstalledUICulture));