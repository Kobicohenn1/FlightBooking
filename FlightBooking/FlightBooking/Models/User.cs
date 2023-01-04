using System.ComponentModel.DataAnnotations;

namespace FlightBooking.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }   
        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
