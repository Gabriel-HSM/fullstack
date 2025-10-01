Console.Write("Digite o tamanho da matriz: ");
string[] matrizTamanho = Console.ReadLine().Split(' ');
int matrizX = int.Parse(matrizTamanho[0]);
int matrizY = int.Parse(matrizTamanho[1]);

int[,] matriz = new int[matrizX, matrizY];

for (int i = 0; i < matrizX; i++)
{
    string[] matrizValores = Console.ReadLine().Split(' ');
    for (int j = 0; j < matrizY; j++)
    {
        matriz[i, j] = int.Parse(matrizValores[j]);
    }
}

int numeroEscolhido = int.Parse(Console.ReadLine());

for (int i = 0; i < matrizX; i++)
{
    for (int j = 0; j < matrizY; j++)
    {
        if (matriz[i, j] == numeroEscolhido)
        {
            Console.WriteLine("Position: " + i + ", " + j);
            if (j > 0)
            {
                Console.WriteLine("Left: " + matriz[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up: " + matriz[i - 1, j]);
            }
            if (j < matrizY - 1)
            {
                Console.WriteLine("Right: " + matriz[i,j + 1]);
            }
            if (i < matrizX - 1)
            {
                Console.WriteLine("Down: " + matriz[i + 1,j]);
            }
        }
    }
}
