using System;

namespace CheckIn
{
    public class Flight
    {
        public string Number { get; }

        public string Location { get; }

        public string AircraftType { get; }

        public byte CheckInNumber { get; }

        public byte Gate { get; }

        public DateTime Time { get; }

        public Flight(string number, string location, string aircraftType, byte checkInNumber, byte gate, DateTime time)
        {
            Number = number;
            Location = location;
            AircraftType = aircraftType;
            CheckInNumber = checkInNumber;
            Gate = gate;
            Time = time;
        }
    }
}
