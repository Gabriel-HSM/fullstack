//----------------------- Exercicio 1 -------------------------


// Console.Write("Digite sua senha: ");
// string senha = Console.ReadLine();

// while (senha != "2002")
// {
//     Console.WriteLine("Senha inválida");
//     Console.Write("Digite sua senha: ");
//     senha = Console.ReadLine();
// }

// Console.WriteLine("Acesso Permitido");


//-------------------------------------------------------------

//----------------------- Exercicio 2 -------------------------


// Console.WriteLine("Digite a coordenada X e Y (Na mesma linha)");
// string[] coordenadas = Console.ReadLine().Split(' ');

// int x = int.Parse(coordenadas[0]);
// int y = int.Parse(coordenadas[1]);


// while (x != 0 && y != 0)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Primeiro");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("Segundo");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Terceiro");
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Quarto");
//     }
//     coordenadas = Console.ReadLine().Split(" ");
//     x = int.Parse(coordenadas[0]);
//     y = int.Parse(coordenadas[1]);
// }

// Console.WriteLine(" ");


//-------------------------------------------------------------

//----------------------- Exercicio 3 -------------------------


// Console.WriteLine("Digite o seu tipo de combustível? ");
// Console.WriteLine(" 1 --- Álcool --- ");
// Console.WriteLine(" 2 -- Gasolina -- ");
// Console.WriteLine(" 3 --- Diesel --- ");
// Console.WriteLine(" 4 ---- Fim ----- ");
// int id = int.Parse(Console.ReadLine());

// int QuantidadeAlcool = 0;
// int QuantidadeGasolina = 0;
// int QuantidadeDiesel = 0;

// if (id > 4 || id < 0)
// {
//     Console.WriteLine("Código inválido, tente novamente");
// }
// else
// {
//     while (id != 4)
//     {
//         if (id == 1)
//         {
//             QuantidadeAlcool++;
//         }
//         else if (id == 2)
//         {
//             QuantidadeGasolina++;
//         }
//         else if (id == 3)
//         {
//             QuantidadeDiesel++;
//         }
//         Console.WriteLine("Digite o seu tipo de combustível? ");
//         Console.WriteLine(" 1 --- Álcool --- ");
//         Console.WriteLine(" 2 -- Gasolina -- ");
//         Console.WriteLine(" 3 --- Diesel --- ");
//         Console.WriteLine(" 4 ---- Fim ----- ");
//         id = int.Parse(Console.ReadLine());
//     }
//     Console.WriteLine("MUITO OBRIGADO");
//     Console.WriteLine("Alcool: " + QuantidadeAlcool);
//     Console.WriteLine("Gasolina: " + QuantidadeGasolina);
//     Console.WriteLine("Diesel: " + QuantidadeDiesel);
// }

//-------------------------------------------------------------
//-------------------------------------------------------------
