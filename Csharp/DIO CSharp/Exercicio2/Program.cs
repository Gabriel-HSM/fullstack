using Exercicio2.models;
using System.Globalization;
using Newtonsoft.Json;


int numero = 20;
bool par = false;

par = numero.ehPar();

string menssagem = "O número " + numero + " " + "é" + (par ? "par" : "impar");
System.Console.WriteLine(menssagem);









// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// System.Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// System.Console.WriteLine(arrayString[0]);
















// dynamic variavelDinamica = 4;

// System.Console.WriteLine($"TIpo da variável: { variavelDinamica.GetType()}, Valor {variavelDinamica}");

// variavelDinamica = "Texto";

// System.Console.WriteLine($"TIpo da variável: { variavelDinamica.GetType()}, Valor {variavelDinamica}");

// variavelDinamica = true;

// System.Console.WriteLine($"TIpo da variável: { variavelDinamica.GetType()}, Valor {variavelDinamica}");





// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
// System.Console.WriteLine($"Produto: {venda.Produto}, Preço {venda.Preco}");
// }













// var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.00 };

// System.Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// System.Console.WriteLine("Nome: " + tipoAnonimo.Sobrenome);
// System.Console.WriteLine("Nome: " + tipoAnonimo.Altura);












// bool? desejaReceberEmail = true;


// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     System.Console.WriteLine("O usuário deseja receber e-mails.");
// }
// else
// {
//     System.Console.WriteLine("O usuário não deseja receber e-mails.");
// }












// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

//  List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//  foreach (Venda venda in listaVenda)
// {
//      System.Console.WriteLine($"ID: {venda.Id}, Produto: {venda.Produto},  Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + (venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : ""));
//  }







// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);


// System.Console.WriteLine(serializado);

















// int numero = 15;
// bool ehPar = false;

// //IF Ternário
// ehPar = numero % 2 == 0;

// System.Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));













// if (numero % 2 == 0)
// {
//     System.Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     System.Console.WriteLine($"O número {numero} é ímpar");
// }













// Pessoa p1 = new Pessoa("Gabriel", "Henrique");

// (string nome, string sobrenome) = p1;

// System.Console.WriteLine($"{nome} {sobrenome}");

















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //System.Console.WriteLine($"quantidades linha do arquivo: {quantidadeLinhas}");

//     foreach (string linha in linhasArquivo)
//     {
//         System.Console.WriteLine(linha);
//     }
// }
// else
// {
// System.Console.WriteLine("Não foi possível ler o arquivo");
// }




















// (int, string, string, decimal) tupla = (1, "Gabriel", "Henrique", 1.80M);
// //ValueTuple<int, string, string, decimal> outroExemplo = (1, "Gabriel", "Henrique", 1.80M);

// //var outroExemplo = Tuple.Create(1, "Gabriel", "Henrique", 1.80M);

// System.Console.WriteLine($" ID: {tupla.Item1}");
// System.Console.WriteLine($" Nome: {tupla.Item2}");
// System.Console.WriteLine($" Sobrenome: {tupla.Item3}");
// System.Console.WriteLine($" Altura: {tupla.Item4}");
















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