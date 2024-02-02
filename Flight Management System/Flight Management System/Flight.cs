using System;
namespace Flight_Management_System
{
	public abstract class Flight
	{
		public string FlightNumber { get; set; }
		public string DepartureCity { get; set; }
		public string ArrivalCity { get; set; }
		public DateTime DepartureTime { get; set; }
		public int AvailableSeats { get; set; }

		public abstract void SearchFlights(List<Flight> flights);
		public abstract void BookATicket(List<Flight> flights, List<Reservation> reservations);
		public abstract void Cancel(List<Flight> flights, List<Reservation> reservations);
        public override string ToString()
        {
            return $"FlightNumber: {FlightNumber} - DepartureCity: {DepartureCity} - ArrivalCity: {ArrivalCity} DateTime: {DepartureTime} -AvailableSeats: {AvailableSeats}";
        }
    }
}

