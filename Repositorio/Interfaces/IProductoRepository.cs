using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IProductoRepository
    {
        bool Registrar(Producto producto);

        Producto Consultar(int id);
        Producto Consultar(string descripcion);
    }
}
