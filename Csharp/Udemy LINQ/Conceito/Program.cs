//LINQ = LANGUAGE INTEGRATED QUERY

//Conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#
//-chamados diretamente a partir de coleções
//-Consultas são objetos de primeira classe
//-Suporte do compilador e intelissense da IDE (INCRIVEL)

//Possui diversar operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxe similar á SQL


//PASSO
//1 - DATA SOURCE(coleção, array, recurso de E/s, etc)
//2 - Definir a query
//3 - Executar a query (foreach ou alguma operação terminal)

class Program
{
    static void Main(string[] args)
    {
        //Especificar a fonte de dados
        int[] numbers = new int[]{ 2, 3, 4, 5};

        //Definir a consulta
        //Where filtra
        IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

        //Executar a consulta
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }
} 