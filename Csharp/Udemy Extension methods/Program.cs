//São metodos que estendem a funcionalidade de um tipo, sem precisar alterar o código fonte deste tipo, nem herdar desse tipo

//COMO?

//Classe estática
//Cria método estático
//O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um parametro do tipo que se deseja estender. Esta será uma referência para o próprio objeto.


DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());

string s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(10));