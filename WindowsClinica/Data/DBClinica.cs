using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClinica.Models;

namespace WindowsClinica.Data
{
    public class DBClinica : DbContext
    {
        public DBClinica() : base("KeyDB") { }

        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }

    }
}
