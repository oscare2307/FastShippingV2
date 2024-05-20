using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;

namespace Pedidos.Mapeos
{
    public class AutoMaperPerfil : Profile
    {
        public AutoMaperPerfil()
        {
            CreateMap<CrearProductoDto, Producto>();
            
            CreateMap<Producto, ProductoCreadoDto>();

            CreateMap<CrearVehiculoDto, Vehiculo>();

            CreateMap<Vehiculo, VehiculoCreadoDto>();

            CreateMap<CrearConductorDto, Conductor>();

            CreateMap<Conductor, ConductorCreadoDto>();

            CreateMap<CrearPedidoDto, Pedido>();

            CreateMap<Pedido, PedidoCreadoDto>();
        }
    }
}
