using System;
using Tratamento_excessoes.Entities;
using Tratamento_excessoes.Entities.Exceptions;

namespace Tratamento_excessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-In Date(dd/MM/yyyy): ");
                DateTime dtCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out Date(dd/MM/yyyy): ");
                DateTime dtCheckOut = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(number, dtCheckIn, dtCheckOut);
                Console.WriteLine("Reservation: " + r);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:  ");
                Console.Write("Check-In Date (dd/MM/yyyy): ");
                dtCheckIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out Date (dd/MM/yyyy): ");
                dtCheckOut = DateTime.Parse(Console.ReadLine());

                r.UpdateDates(dtCheckIn,dtCheckOut);
                Console.WriteLine("Reservation: " + r);
            }
            catch(DomainException e )
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
