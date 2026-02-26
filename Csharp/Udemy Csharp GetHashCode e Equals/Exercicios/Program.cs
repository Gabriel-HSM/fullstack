using Exercicios.Entities;

//ordem não importa então use o mais rapido

HashSet<LogRecord> set = new HashSet<LogRecord>();

Console.WriteLine("Enter file full path: ");
string? path = Console.ReadLine();

if (path is null)
throw new ArgumentException("Digite um caminho válido");

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord {UserName= name, Instant = instant});

            Console.WriteLine(line);
        }

        Console.WriteLine("Total users: " + set.Count);
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}