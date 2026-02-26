using System.Collections.Generic;

//Não admite repetições
//Elementos não possuem posição
//Acesso, inserção e remoção são rapidos
//Oferece operações eficientes de conjunto: interseção, união, diferença

//HashSet
//Armazenmento em tabela Hash
//Rapido demaisi,inserção, remoção e busca O(1) (passo 1, (calculo do hash  e algumas operações))
// A ordem dos elementos não é garantido

//SortedSet
//Armazenamento em árvore
//Rápido: inserção, remoção e busca O(log(n))
//Elementos são armazenados ordenadamente conforme implementação do IComparer

//(acesso em uma arvore balanceada é na ordem de log(n)base 2 )
//pelo que entendi é dipo 2^10 = 1024 e log de 1024 com base 2 é 10;

//principais metodos
/*
add,
clear
contains
UNioWith(other)
InterceptWith(other)
ExceptWith(other)
Remove(t)
removeWhere(predicate)
*/


    //HashSet
    HashSet<string> set = new HashSet<string>(); //set = ["TV", "Notebook", "Tablet"];

    set.Add("TV");
    set.Add("Notebook");
    set.Add("Tablet");

    Console.WriteLine(set.Contains("Computer"));

    foreach (string p in set)
    {
        Console.WriteLine(p);
    }

    //SortedSet
    SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
    SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9 ,10};

    //União, acrecenta quem não existia 
    SortedSet<int> c = new SortedSet<int>(a);
    c.UnionWith(b);
    PrintCollection(c);

    //Intercessão
    SortedSet<int> d = new SortedSet<int>(a);
    d.IntersectWith(d);
    PrintCollection(d);

    //Diferença
    SortedSet<int> e = new SortedSet<int>(a);
    e.ExceptWith(b);
    PrintCollection(e);


static void PrintCollection<T>(IEnumerable<T> collection) 
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
    
}