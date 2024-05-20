using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;
using Servicio.Interfaces;
using Repositorio.Interfaces;

namespace Servicio
{
    public class VehiculoService : IVehiculoService
    {
        private readonly IVehiculoRepository _repository;
        private readonly IMapper _mapper;

        public VehiculoService(IVehiculoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Vehiculo Consultar(int id)
        {

            return _repository.Consultar(id);
        }

        public bool Existe(int id)
        {
            return _repository.Existe(id);
        }

        public VehiculoCreadoDto Registrar(CrearVehiculoDto dto)
        {


            var existe = _repository.Consultar(dto.Matricula);

            if (existe is null)
            {

                var vehiculo = _mapper.Map<Vehiculo>(dto);
                vehiculo.Matricula = "Registrado";
                vehiculo.FechaRegistro = DateTime.Now;
                vehiculo.Marca = vehiculo.Matricula.Substring(0, 1).ToUpper() + new Random().NextInt64(1, 10000);

                // Viola el principio de ID
                //ProductoRepository _repository = new ProductoRepository();
                _repository.Registrar(vehiculo);

                var vehiculoCreado = _mapper.Map<VehiculoCreadoDto>(vehiculo);

                return vehiculoCreado;

            }

            return null;
        }
    }
}

