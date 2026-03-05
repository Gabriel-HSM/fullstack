using Udemy_ComparisonT.Entities;

List <Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

//Delegate
//Sintaxe:
//public delegate int Comparison<in T>(T x, T y);

//Comparison<Product> comp = CompareProducts;

//FUNÇÃO ANÔNIMA OU LAMBDA
Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort(comp); // ou
//list.Sort(compareProducts);

foreach (Product p in list)
{
    Console.WriteLine(p);
}


static int CompareProducts(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}