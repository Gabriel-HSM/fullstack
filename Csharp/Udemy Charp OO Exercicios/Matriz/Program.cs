Console.WriteLine("Digite o tamanho da matriz");
int matrizTamanho = int.Parse(Console.ReadLine());

int[,] matriz = new int[matrizTamanho, matrizTamanho];

for (int i = 0; i < matrizTamanho; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    for (int c = 0; c < matrizTamanho; c++)
    {
        matriz[i, c] = int.Parse(valores[c]);
    }

}

Console.WriteLine("Main diagonal: ");
for (int i = 0; i < matrizTamanho; i++)
{
    Console.Write(matriz[i, i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < matrizTamanho; i++)
{
    for (int c = 0; c < matrizTamanho; c++)
    {
        if (matriz[i, c] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine("Negative Numbers: " + count);

