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
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DbContexto _context;
        public PedidoRepository(DbContexto context)
        {

            _context = context;
        }

        public Pedido Consultar(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public Pedido Consultar(string estadoPedido)
        {
            return _context.Pedidos.FirstOrDefault(x => x.estadoPedido.Equals(estadoPedido));
        }

        public bool Registrar(Pedido pedido)
        {
            _context.Add(pedido);
            return _context.SaveChanges() > 0;
        }
    }
}
