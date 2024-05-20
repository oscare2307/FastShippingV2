using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IPedidoRepository
    {
        bool Registrar(Pedido pedido);

        Pedido Consultar(int id);
        Pedido Consultar(string estadoPedido);
    }
}
