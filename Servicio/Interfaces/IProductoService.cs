using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Dtos;
using Dominio.Entities;
namespace Servicio.Interfaces
{
    public interface IProductoService
    {
        ProductoCreadoDto Registrar(CrearProductoDto dto);
        Producto Consultar(int id);
    }
}
