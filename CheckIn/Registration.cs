using System;
using System.Threading;

namespace CheckIn
{
    class Registration
    {
        public void Run(PassengerProfile profile)
        {
            Console.WriteLine();
            Console.WriteLine(" - Hello. Please, introduce yourself...");
            Console.Write(" First name: ");
            profile.FirstName = Console.ReadLine();
            Console.Write(" Last name: ");
            profile.LastName = Console.ReadLine();
            Console.Write(" Passport number: ");
            profile.PassportNumber = Console.ReadLine();
            Console.WriteLine();

            AirportBoard board = new AirportBoard();

            Console.WriteLine(" - Ok. Do you have baggage? Yes or no?");
            string yes = Console.ReadLine();
            if (yes == "yes")
            {
                Console.WriteLine(" - Put your bags on the scales, please...");
                Thread.Sleep(2000);
                Random rand = new Random();
                var weight = rand.Next(10, 23);
                Console.WriteLine($" - Weight is {weight} - it's OK. Here your boarding pass...");
            }
            else
            {
                Console.Beep();
                Console.WriteLine(" - Here your boarding pass...");
            }
            Console.WriteLine($"   ...your Gate number is {board.GetGateNumber(profile.FlightNumber)}");
            Console.WriteLine();
        }
    }
}