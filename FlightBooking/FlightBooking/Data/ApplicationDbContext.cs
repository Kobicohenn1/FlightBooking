﻿using FlightBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
    {

    }
    public DbSet<Flight> Flights { get; set; }

    public DbSet<User> Users { get; set; }
 
    public DbSet<Booking> Bookings { get; set; }
    
}


