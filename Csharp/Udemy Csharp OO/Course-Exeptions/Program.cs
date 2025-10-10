using System;
using Course_Exeptions.Entities;
using Course_Exeptions.Entities.Exceptions;


try
{
    Console.WriteLine("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDate(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}

// Semantica ruim e retornar string tem que ser void, pois se for um tipo string já teria que fazer uma gambiarra. Não dá pra tratar exceções em construtores pois não da pra retornar co construtor. Logica de reserva é na reserva. 

// Console.WriteLine("Room number: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Check-in date (dd/MM/yyyy): ");
// DateTime checkIn = DateTime.Parse(Console.ReadLine());
// Console.WriteLine("Check-out date (dd/MM/yyyy): ");
// DateTime checkOut = DateTime.Parse(Console.ReadLine());


// if (checkOut <= checkIn)
// {
//     Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
// }
// else
// {
//     Reservation reservation = new Reservation(number, checkIn, checkOut);
//     Console.WriteLine("Reservation: " + reservation);

//     Console.WriteLine();
//     Console.WriteLine("Enter data to update the reservation: ");
//     checkIn = DateTime.Parse(Console.ReadLine());
//     Console.WriteLine("Check-out date (dd/MM/yyyy): ");
//     checkOut = DateTime.Parse(Console.ReadLine());

//     string error = reservation.UpdateDate(checkIn, checkOut);
//     if (error != null)
//     {
//         Console.WriteLine("Error in reservation " + error);
//     }
//     else
//     {
//         Console.WriteLine("Reservation: " + reservation);
//     }
// }


// Program de forma errada, feio / ruim

// Console.WriteLine("Room number: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Check-in date (dd/MM/yyyy): ");
// DateTime checkIn = DateTime.Parse(Console.ReadLine());
// Console.WriteLine("Check-out date (dd/MM/yyyy): ");
// DateTime checkOut = DateTime.Parse(Console.ReadLine());


// if (checkOut <= checkIn)
// {
//     Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
// }
// else
// {
//     Reservation reservation = new Reservation(number, checkIn, checkOut);
//     Console.WriteLine("Reservation: " + reservation);

//     Console.WriteLine();
//     Console.WriteLine("Enter data to update the reservation: ");
//     checkIn = DateTime.Parse(Console.ReadLine());
//     Console.WriteLine("Check-out date (dd/MM/yyyy): ");
//     checkOut = DateTime.Parse(Console.ReadLine());

//     DateTime now = DateTime.Now;

//     if (checkIn < now || checkOut < now)
//     {
//         Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
//     }
//     else if (checkOut <= checkIn)
//     {
//         Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
//     }
//     else
//     {
//         reservation.UpdateDate(checkIn, checkOut);
//         Console.WriteLine("Reservation: " + reservation);
//     }
// }


// try
// {
//     int n1 = int.Parse(Console.ReadLine());
//     int n2 = int.Parse(Console.ReadLine());

//     int result = n1 / n2;
//     Console.WriteLine(result);
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Divission by zero is not allowed");
// }
// catch (FormatException e)
// {
//     Console.WriteLine("Format error! " + e.Message);
// }