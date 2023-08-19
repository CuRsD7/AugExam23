using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugExam23
{
    public class Booking
    {
        // Variables
        public int BookingID { get; set; }
        public DateTime BookingsStartDate { get; set; }
        public DateTime BookingsEndDate { get; set; }

        // Foreign key for the one-to-many relationship
        public int CarId { get; set; }
        public Car Car { get; set; }
    }

    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }

        // Navigation property for the one-to-many relationship
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public class CarData : DbContext
    {
        public CarData(): base("OODExam_MiloszMartyka") { }
        public DbSet<Booking> Bookings { get; set;}
        public DbSet<Car> Cars { get; set;}
    }
}
