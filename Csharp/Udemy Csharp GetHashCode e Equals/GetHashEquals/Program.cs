//Comparar se um objeto é maior que outro

//Equals, lento, resposta 100% : retorna true or false

//GetHashCode, rapido, porém resposta positiva não é 100% : retorna um numero inteiro representando um código gerado a partir das informações do obj


//Equals
using Udemy_Csharp_GetHashCode_e_Equals.Entities;

string a = "Maria";
string b = "Alex";

Console.WriteLine(a.Equals(b));

//HashCode
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());


//Program

Client client1 = new Client{Name = "Maria", Email = "maria@gmail.com"};
Client client2 = new Client{Name = "Alex", Email = "Alex@gmail.com"};

Console.WriteLine(client1.Equals(client2));
//ponteiro de memória
Console.WriteLine(client1 == client2);
Console.WriteLine(client1.GetHashCode());
Console.WriteLine(client2.GetHashCode());