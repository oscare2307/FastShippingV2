using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;
using Servicio.Interfaces;
using Repositorio.Interfaces;

namespace Servicio
{
    public class ProductoService :IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Producto Consultar(int id)
        {

            return _repository.Consultar(id);
        }

        public ProductoCreadoDto Registrar(CrearProductoDto dto)
        {


            var existe = _repository.Consultar(dto.Descripcion);

            if (existe is null)
            {

                var producto = _mapper.Map<Producto>(dto);
                producto.Estado = "Registrado";
                producto.FechaRegistro = DateTime.Now;
                producto.Codigo = producto.Categoria.Substring(0, 1).ToUpper() + new Random().NextInt64(1, 10000);

                // Viola el principio de ID
                //ProductoRepository _repository = new ProductoRepository();
                _repository.Registrar(producto);

                var productoCreado = _mapper.Map<ProductoCreadoDto>(producto);

                return productoCreado;

            }

            return null;
        }
    }
}
