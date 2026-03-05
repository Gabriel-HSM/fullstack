Console.WriteLine("Enter file full path: ");
string? path = Console.ReadLine();

 Dictionary<string, int> votes = new Dictionary<string, int>();

try
{
    
    //Ler arquivos de txt
    using (StreamReader streamReader = File.OpenText(path))
    {
        while (!streamReader.EndOfStream)
        {
            string[] line = streamReader.ReadLine().Split(",");
            string key = line[0];
            int value = int.Parse(line[1]);

            if (votes.ContainsKey(key))
            {
                votes[key] += value;
            } 
            else
            {
               votes[key] = value;
            }

        }

        foreach (var item in votes)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
    
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}