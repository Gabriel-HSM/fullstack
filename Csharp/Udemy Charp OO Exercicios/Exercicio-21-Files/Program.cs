using System.Globalization;
using Exercicio_21_Files.Entities;

string imputPath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\imput.csv";

string directoryPath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\out";
Directory.CreateDirectory(directoryPath);

string summaryPath = @"C:\Projetos\fullstack\Csharp\Udemy Csharp OO\Files-Examples\out\summary.csv";


string[] lines = File.ReadAllLines(imputPath);

try
{
    using(StreamWriter summaryLines = File.AppendText(summaryPath))
    {
        foreach(string line in lines)
        {
            string[] items = line.Split(",");
            string itemName = items[0];
            double itemValue = double.Parse(items[1], CultureInfo.InvariantCulture); 
            int itemQuantity = int.Parse(items[2]);

            Product product = new Product(itemName, itemValue, itemQuantity);

            summaryLines.WriteLine(product.Name + ", " + product.TotalPrice().ToString("F2", CultureInfo.InstalledUICulture));



        }
    }

}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}