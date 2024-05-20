using Dominio.Dtos;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Interfaces
{
    public interface IPedidoService
    {
        PedidoCreadoDto Registrar(CrearPedidoDto dto);
        Pedido Consultar(int id);
    }
}
