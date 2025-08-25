using Exercicio2.models;
using System.Globalization;



// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// System.Console.WriteLine(estados["MG"]);

// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("--------------------");

// //estados.Remove("BA");

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
// }

// string chave = "BA";
// System.Console.WriteLine($"Verificando o elemento ");

// if (estados.ContainsKey(chave))
// {
//     System.Console.WriteLine($"Valor existente {chave}");
// }
// else
// {
//     System.Console.WriteLine($"É seguro adicionar a chave: {chave}");
// }


















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

















// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }
















// new ExemploExcecao().Metodo1();



































//string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
// System.Console.WriteLine("Chegou aqui");

// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }


// }
// catch (FileNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
// System.Console.WriteLine("Chegou aqui");
// }











// string dataString = "2022-04-17 18:00";


// bool sucesso = DateTime.TryParseExact(dataString,
//     "yyyy-MM-dd HH:mm",
//     CultureInfo.InvariantCulture,
//     DateTimeStyles.None,
//     out DateTime data);


// if (sucesso)
// {
//     System.Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }
















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMoneario = 82.40M;

// Console.WriteLine(valorMoneario.ToString("N2"));

// double porcentagem = .3421;

// System.Console.WriteLine(porcentagem.ToString("P"));











// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);









// Pessoa p1 = new Pessoa(nome: "Gabriel", sobrenome: "Xavier");

// Pessoa p2 = new Pessoa("Eduardo","Neves");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();








// p1.Nome = "Gabriel";
// p1.Sobrenome = "Xavier";
// p1.Idade = 20;
// p1.Apresentar();