using System.ComponentModel.DataAnnotations;

namespace FlightBooking.Models
{
    public class Flight
    {
        [Key]
        [Required]
        public int FlightId { get; set; }
        [Required]
        public string OriginCountry { get; set; }
        [Required]
        public string DestinationCountry { get; set; }
        [Required]
        public DateTime FlightDate { get; set; }
        [Required]
        public TimeSpan ExpireDate { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int AvailableSeats { get; set; }

    }
}
