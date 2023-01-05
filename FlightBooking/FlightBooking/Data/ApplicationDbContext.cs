using FlightBooking.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
    {

    }
    public DbSet<Flight> Flights { get; set; }

    public DbSet<User> Users { get; set; }
 
    public DbSet<Booking> Bookings { get; set; }
    
}


