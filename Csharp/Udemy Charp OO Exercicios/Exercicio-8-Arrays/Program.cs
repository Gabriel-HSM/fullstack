using Exercicio_Arrays;

Aluguel[] quartos = new Aluguel[10];

string nome;
string email;
int quantidadeAlugar;
int numeroQuarto;

Console.Write("Quantos quartos serão alugados? ");
quantidadeAlugar = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidadeAlugar; i++)
{
    Console.WriteLine("Aluguel #" + i);

    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Email: ");
    email = Console.ReadLine();

    Console.Write("Quarto: ");
    numeroQuarto = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    if (quartos[numeroQuarto] == null)
    {
        quartos[numeroQuarto] = new Aluguel(nome, email);
    }
    else
    {
        while (quartos[numeroQuarto] != null)
        {
            Console.WriteLine("Quarto número " + numeroQuarto + " ocupado, escolha outro quarto:");
            Console.WriteLine("");
            Console.WriteLine("Quartos disponíveis: ");

            for (int c = 1; c < quartos.Length; c++)
            {
                if (quartos[c] == null)
                {
                    Console.Write($" {c} ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Escolha um quarto disponível");
            Console.WriteLine("Quarto: ");
            numeroQuarto = int.Parse(Console.ReadLine());
        }
        quartos[numeroQuarto] = new Aluguel(nome, email);
    }
}

Console.WriteLine("Quartos ocupados: ");
for (int i = 0; i < 10; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine($"{i}: {quartos[i]}");
    }
}