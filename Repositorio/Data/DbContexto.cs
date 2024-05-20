using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Data
{
    public class DbContexto(DbContextOptions<DbContexto> opt) : DbContext(opt)
    {
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}


