using System;
namespace Flight_Management_System
{
	public class Reservation : Flight
	{
		public string PassengerName { get; set; }
        public List<Flight> Flights = new List<Flight>();

        public override void SearchFlights(List<Flight> flights)
        {
            throw new NotImplementedException();
        }
        public override void BookATicket(List<Flight> flights, List<Reservation> reservations)
        {
            throw new NotImplementedException();
        }
        public override void Cancel(List<Flight> flights, List<Reservation> reservations)
        {
            throw new NotImplementedException();
        }
    }
}

