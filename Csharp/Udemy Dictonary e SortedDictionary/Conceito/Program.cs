// Coleção chave e valor
// Não admite repetições
// OS elementos são indexados pelo objeto chave (Não possuem posição)
// Acesso, inserção e remoção de elementos rápidos

//Uso comuns: cookies, local storage, qualuqer modelo chave-valor

//DICTIONARY 
//- Armazenamento em tabela hash
//- Extremamente rápido o(1)
//- Ordem dos elementos não garantida

//SORTEDDICTIONARY
//- Armazenamento árvore
//- Rápido O(log(n))
//- Ordenado conforme implementação IComparer<T>

//Parecido com hashset e sortetset

//SINTAXE
//dictionary[key]
//add(key,value)
//clear()
//Count
//ContainsKey(key)
//ContainsValue(value)
//Remove(Key)


Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99711234";
cookies["phone"] = "89876523";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no email key");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("ALL COOKIES");
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}

//Outra forma mais simoples: 
foreach( var item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}