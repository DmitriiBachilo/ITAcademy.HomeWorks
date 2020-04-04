using System;
using System.Collections.Generic;
using System.Text;

namespace CheckIn
{
    public class AirportBoard
    {
        private static readonly List<Flight> _flights = new List<Flight>
        {
            new Flight("B2 871", "Geneva", "CRJ 100/200", 9, 27, new DateTime(2020, 4, 14, 16, 30, 0)),
            new Flight("B2 865", "Paris", "Embraer 175", 7, 28, new DateTime(2020, 4, 14, 16, 55, 0)),
            new Flight("B2 867", "Amsterdam", "Boeing 737-300", 5, 25, new DateTime(2020, 4, 14, 17, 20, 0))
        };

        public List<Flight> Flights
        {
            get { return _flights; }
        }

        public List<string> GetFlightNumbers()
        {
            List<string> numbers = new List<string>();
            foreach (var flight in _flights)
            {
                numbers.Add(flight.Number);
            }

            return numbers;
        }

        public Flight GetFlight(string number)
        {
            foreach (var flight in _flights)
            {
                if (flight.Number == number)
                {
                    return flight;
                }
            }

            return null;
        }
    }
}
