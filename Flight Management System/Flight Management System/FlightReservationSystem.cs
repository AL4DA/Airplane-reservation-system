using System;
namespace Flight_Management_System
{
	public class FlightReservationSystem : Flight
	{
        public List<Flight> Flights = new List<Flight>();
        public List<Reservation> Reservations = new List<Reservation>();

        public override void SearchFlights(List<Flight> flights)
        {
            string departureCity;
            string arrivalCity;
            foreach (var item in flights)
            {
                Console.Write("Enter the place of departure: ");
                departureCity = Console.ReadLine();
                Console.Write("Enter the city of arrival: ");
                arrivalCity = Console.ReadLine();

                if (item.DepartureCity == departureCity && item.ArrivalCity == arrivalCity )
                {
                    Console.WriteLine(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
        }

        public override void BookATicket(List<Flight> flights,List<Reservation> reservations)
        {
            Console.WriteLine("Select the flight number: ");
            string flightnumber = Console.ReadLine();
            Console.Write("Please enter the name of the passenger: ");
            string pasagername = Console.ReadLine();

            Flight selecteflight = null;
            foreach (var item in flights)
            {
                if (item.FlightNumber == flightnumber)
                {
                    selecteflight = item;
                }
            }
            if (selecteflight == null)
            {
                Console.WriteLine("Flight not found.");
            }

            Console.WriteLine("Book a flight number");

            string reservationNumber = Console.ReadLine();
            Reservation newReservation = new Reservation
            {
                PassengerName = pasagername,
                FlightNumber = selecteflight.FlightNumber
            };

            reservations.Add(newReservation);

            Console.WriteLine("Reservation successfully created.");
            Console.WriteLine($"Reservation Number: {reservationNumber}");
        }
        public override void Cancel(List<Flight> flights, List<Reservation> reservations)
        {
            Console.WriteLine("Enter the passenger's name");
            string pass = Console.ReadLine();

            Reservation reservation;

            bool found = false;

            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i] is Reservation && reservations[i].PassengerName == pass)
                {
                    found = true;
                    reservations.RemoveAt(i);
                    Console.WriteLine("has been cancelled");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Passenger not found");
            }
        }
    }
}

