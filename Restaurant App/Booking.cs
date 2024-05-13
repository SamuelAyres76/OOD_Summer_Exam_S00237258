using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Restaurant_App
{
    public class Booking
    {
        // My Variables
        public int BookingId { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOfParticipants { get; set; }

        // My Nav property
        public virtual ICollection<Customer> Customers { get; set; }

        // My Constructor
        public Booking()
        {
            Customers = new List<Customer>();
        }
    }

    public class Customer
    {
        // My Variables
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        // My Nav Property
        public virtual ICollection<Booking> Bookings { get; set; }
    }

    public class CustomerClass : DbContext
    {
        public CustomerClass(string dbName) : base(dbName) { }

        public CustomerClass() : this("OODExam_SamuelAyres") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}