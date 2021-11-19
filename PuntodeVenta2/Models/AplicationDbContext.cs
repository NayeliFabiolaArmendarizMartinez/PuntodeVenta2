using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta2.Models
{
    class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=Clase3; Username=postgres; password=1234567;")
                .EnableSensitiveDataLogging(true);

            base.OnConfiguring(optionsBuilder);
            /*optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Clase; Itegrated Security=True")
                .EnableSensitiveDataLogging(true);
            */

        }
        //propiedad la cual le indica a EFC que vamos a tener una tabla Empleados
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }

}
