// 1 - 
// using System;

// public interface IAnimal{
//     public void FazerSom();
// }

// class Cachorro : IAnimal{
//      public void FazerSom(){
//          Console.WriteLine("Au Au");
//      }
// }

// public class MainTwo
// {
//     public static void Main(string[] args)
//     {
//         Cachorro max = new Cachorro();
//         max.FazerSom();
//     }
// }

// -------------------------------------------------------------------------------
// -------------------------------------------------------------------------------

// 2 - using System;
// using System.Collections.Generic;

// public interface IVehicle
// {
//     public string PowerOn();
//     public string PowerOff();
// }

// public class Car : IVehicle
// {
//     public string Model {get;set;}

//     public Car(string model){
//         Model = model;
//     }

//     public string PowerOn()
//     {
//         return "Vraum Vraum";
//     }

//     public string PowerOff()
//     {
//         return "Kabaun Kabaun";
//     }

//     public override string ToString(){
//         return Model;
//     }
// }

// public class Motorcycle : IVehicle
// {
//     public string Model {get;set;}

//     public Motorcycle(string model){
//         Model = model;
//     }

//     public string PowerOn()
//     {
//         return "Vrum Vrum";
//     }

//     public string PowerOff()
//     {
//         return "Kabun Kabun";
//     }

//      public override string ToString(){
//         return Model;
//     }
// }

// public class Vehicle
// {
//     public static void Main(string[] args)
//     {
//         List<IVehicle> vehicles = new List<IVehicle>();
//         vehicles.Add(new Car("Civic"));
//         vehicles.Add(new Motorcycle("Fazer"));

//         foreach (IVehicle vehicle in vehicles){
//             Console.WriteLine(vehicle);
//         }
//     }
// }

// -------------------------------------------------------------------------------
// -------------------------------------------------------------------------------

// NIvel 2

// public interface IUser
// {
//     public string Name { get; set; }
//     public void Login();
// }

// public class Admin : IUser
// {
//     public string Name { get; set; }

//     public Admin(string name)
//     {
//         Name = name;
//     }

//     public void Login()
//     {
//         Console.WriteLine("Admin " + Name + " logado!");
//     }
// }

// public class Client : IUser
// {
//     public string Name { get; set; }

//     public Client(string name)
//     {
//         Name = name;
//     }

//     public void Login()
//     {
//         Console.WriteLine("Cliente " + Name + " logado!");
//     }
// }

// public class User
// {
//     public static void Main(string[] args)
//     {
//         string name1 = "Larissa";
//         string name2 = "Gabriel";

//         Client client = new Client(name1);
//         Admin admin = new Admin(name2);

//         client.Login();
//         admin.Login();
//     }
// }

// -------------------------------------------------------------------------------
// -------------------------------------------------------------------------------
// nivel 3

// using System.Security.Cryptography.X509Certificates;

// public interface IPayments
// {
//     public void ProcessPayment(decimal value);
// }

// public class PixPayment : IPayments
// {
//     public void ProcessPayment(decimal value)
//     {
//         Console.WriteLine("Processando pagamento de R$100,00 via PIX");
//     }
// }
// public class CardPayment : IPayments
// {
//     public void ProcessPayment(decimal value)
//     {
//         Console.WriteLine("Processando pagamento de R$250,00 via cartão");
//     }
// }
// public class SlipPayment : IPayments
// {
//     public void ProcessPayment(decimal value)
//     {
//         Console.WriteLine("Processando pagamento de R$300,00 via boleto");
//     }
// }
// public class Payment
// {
//     public static void Main(string[] args)
//     {
//         //Porque criar um tipo IPayments? qual sentido não sabia que podia usar essa interface dessa forma? porque instanciar ela? qual sentido de intanciar??? 
//         void MakePayment(IPayments payment, decimal value)
//         {
//             payment.ProcessPayment(value);
//         }

//         decimal gabrielPayment = 400;
//         decimal larissaPayment = 300;

//         MakePayment(new CardPayment(), gabrielPayment);
//         MakePayment(new PixPayment(), larissaPayment);
//     }
// }

//Nivel 4

public interface IRegistrer
{
    public void Save();
}

public class People
{
    public string Name { get; set; }

    public People(string name)
    {
        Name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name);
    }
}

public class Client : People
{
    public string Name { get; set; }
    
    public Client(string name)
    {
        Name = name;
    }
}




public class Payment
{
    public static void Main(string[] args)
    {
        //Porque criar um tipo IPayments? qual sentido não sabia que podia usar essa interface dessa forma? porque instanciar ela? qual sentido de intanciar??? 
        void MakePayment(IPayments payment, decimal value)
        {
            payment.ProcessPayment(value);
        }

        decimal gabrielPayment = 400;
        decimal larissaPayment = 300;

        MakePayment(new CardPayment(), gabrielPayment);
        MakePayment(new PixPayment(), larissaPayment);
    }
}