using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Models
{
    public class CarSharingContext : DbContext
    {
        public CarSharingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CarModel> cars { get; set; }
    }
}
