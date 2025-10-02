using System.Runtime.CompilerServices;


int jogador1 = 0;
int jogador2 = 0;
int turno = 0;

string escolha;
bool partida = true;

Console.WriteLine("JOGADOR 1 ESCOLHA SE É X OU O (X/O)");
escolha = Console.ReadLine();

if (escolha == "x" || escolha == "X")
{
    jogador1 = 1;
    jogador2 = 2;
    Console.Write("Jogador 1 = X ");
    Console.WriteLine("Jogador 2 = O");
}
else if (escolha == "O" || escolha == "O")
{
    jogador2 = 1;
    jogador1 = 2;
    Console.Write("Jogador 1 = O ");
    Console.WriteLine("Jogador 2 = X");
}

Console.WriteLine();
Console.WriteLine("Jogador 1 começa: ");
Console.WriteLine("Escolha a linha e a coluna da jogada:");


Console.WriteLine("     0           1          2    ");
Console.WriteLine("           |          |          ");
Console.WriteLine("0          |          |          ");
Console.WriteLine("           |          |          ");
Console.WriteLine("  -------- | -------- | -------- ");
Console.WriteLine("           |          |          ");
Console.WriteLine("1          |          |          ");
Console.WriteLine("           |          |          ");
Console.WriteLine("  -------- | -------- | -------- ");
Console.WriteLine("           |          |          ");
Console.WriteLine("2          |          |          ");
Console.WriteLine("           |          |          ");
Console.WriteLine("                                 ");

int[,] jogoDaVelha = new int[3, 3];

while (partida == true)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            string[] jogada = Console.ReadLine().Split(' ');
            int jogadaX = int.Parse(jogada[0]);
            int jogadaY = int.Parse(jogada[1]);
            int jogador;
            turno++;

            if (turno % 2 == 0)
            {
                jogador = jogador1;
            }
            else
            {
                jogador = jogador2;
            }

            if (jogoDaVelha[jogadaX, jogadaY] == 0)
            {
                jogoDaVelha[jogadaX, jogadaY] = jogador;
            }
            else
            {
                while (jogoDaVelha[jogadaX, jogadaY] != 0)
                {
                    Console.WriteLine("Já ocupado tente de novo: ");
                    jogada = Console.ReadLine().Split(' ');
                    jogadaX = int.Parse(jogada[0]);
                    jogadaY = int.Parse(jogada[1]);
                }
                jogoDaVelha[jogadaX, jogadaY] = jogador;
            }

           
        }
    }
            partida = false;
}