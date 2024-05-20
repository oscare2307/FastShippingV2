using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;
using Servicio.Interfaces;
using Repositorio.Interfaces;

namespace Servicio
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Pedido Consultar(int id)
        {

            return _repository.Consultar(id);
        }

        public PedidoCreadoDto Registrar(CrearPedidoDto dto)
        {


            var existe = _repository.Consultar(dto.Descripcion);

            if (existe is null)
            {

                var pedido = _mapper.Map<Pedido>(dto);
                pedido.estadoPedido = "Registrado";
                pedido.FechaRegistro = DateTime.Now;
                pedido.Descripcion = pedido.Descripcion.Substring(0, 1).ToUpper() + new Random().NextInt64(1, 10000);

                // Viola el principio de ID
                //ProductoRepository _repository = new ProductoRepository();
                _repository.Registrar(pedido);

                var pedidoCreado = _mapper.Map<PedidoCreadoDto>(pedido);

                return pedidoCreado;

            }

            return null;
        }
    }
}
