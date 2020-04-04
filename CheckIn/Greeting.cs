using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;

namespace CheckIn
{
    public class Greeting
    {
        private readonly AirportBoard _board = new AirportBoard();

        public void Run()
        {
            Console.WriteLine($"Welcome to Minsk National Airport \nLocal time: {DateTime.Now}");
            Console.WriteLine();
            PrintBoard();

            Console.Write("Enter your flight number, please: ");
            string passengerFlightNumber = Console.ReadLine();
            Flight passengerFlight = _board.GetFlight(passengerFlightNumber);

            while (passengerFlight == null)
            {
                Console.Write("Invalid flight number, please, try again: ");
                passengerFlightNumber = Console.ReadLine();
                passengerFlight = _board.GetFlight(passengerFlightNumber);
            }

            Console.WriteLine();
            Console.WriteLine($"Go to your check-in table number: {passengerFlight.CheckInNumber}");

            //Console.WriteLine("Hello. Introduce yourself, please.");
            //Console.Write("First name: ");
            //string firstName = Console.ReadLine();
            //Console.Write("Last name: ");
            //string lastName = Console.ReadLine();
            //Console.Write("Passport number: ");
            //string passportNumber = Console.ReadLine();
            //Console.Write("Flight number: ");
            //string flightNumber = Console.ReadLine();
        }

        private void PrintBoard()
        {
            Console.WriteLine("  Flight   | to          | Aircraft type    | Departure time");
            Console.WriteLine("           |             |                  |               ");
            foreach (var flight in this._board.Flights)
            {
                Console.WriteLine($"  {flight.Number, -8} | {flight.Location, -11} | {flight.AircraftType, -16} | {flight.Time}");
            }

            Console.WriteLine();
        }
    }
}
