using Repositorio.Interfaces;
using Dominio.Entities;
using Repositorio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Dtos;

namespace Repositorio
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DbContexto _context;
        public ProductoRepository(DbContexto context)
        {

            _context = context;
        }

        public Producto Consultar(int id)
        {
            return _context.Productos.Find(id);
        }

        public Producto Consultar(string descripcion)
        {
            return _context.Productos.FirstOrDefault(x => x.Descripcion.Equals(descripcion));
        }

        public bool Registrar(Producto producto)
        {
            _context.Add(producto);
            return _context.SaveChanges() > 0;
        }
    }
}
