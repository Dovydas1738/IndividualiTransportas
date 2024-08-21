using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndividualiTransportas.Models;

namespace IndividualiTransportas.Repositories
{
    public class IndividualiTransportasContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=IndividualiTransportas;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
