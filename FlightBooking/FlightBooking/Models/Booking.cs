using System.ComponentModel.DataAnnotations;

namespace FlightBooking.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int DepartingFlightId { get; set; }
        public int ReturnFlightId { get; set; } = -1;
        public int DepartingSeatNumber { get; set; }


    }
}
