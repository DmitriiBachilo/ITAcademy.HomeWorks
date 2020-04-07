using System;

namespace CheckIn
{
    public class Greeting
    {
        private readonly AirportBoard _board = new AirportBoard();

        public void Run(PassengerProfile profile)
        {
            Console.WriteLine($" Welcome to Minsk National Airport \n Local time: {DateTime.Now}");
            Console.WriteLine();
            PrintBoard();        

            Console.Write(" - Enter your flight number, please: ");
            string passengerFlightNumber = Console.ReadLine();
            Flight passengerFlight = _board.GetFlight(passengerFlightNumber);

            while (passengerFlight == null)
            {
                Console.Write("Invalid flight number, please, try again: ");
                passengerFlightNumber = Console.ReadLine();
                passengerFlight = _board.GetFlight(passengerFlightNumber);
            }

            profile.FlightNumber = passengerFlightNumber;

            Console.WriteLine();
            Console.WriteLine($" - Go to your check-in table number: {passengerFlight.CheckInNumber}");
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
