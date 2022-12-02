using Microsoft.EntityFrameworkCore;
using WebPasajero.Models;

namespace WebPasajero.Data
{
    public class PasajeroContext :DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> options): base(options){}
        public DbSet<Pasajero> Pasajeros { get; set; }
    }
}
