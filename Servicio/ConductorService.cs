using AutoMapper;
using Dominio.Dtos;
using Dominio.Entities;
using Servicio.Interfaces;
using Repositorio.Interfaces;

namespace Servicio
{
    public class ConductorService : IConductorService
    {
        private readonly IConductorRepository _repository;
        private readonly IMapper _mapper;
        private readonly IVehiculoService _vehiculoService;


        public ConductorService(IConductorRepository repository, IMapper mapper, IVehiculoService vehiculoService)
        {
            _mapper = mapper;
            _repository = repository;
            _vehiculoService = vehiculoService;
        }

        public Conductor Consultar(int id)
        {

            return _repository.Consultar(id);
        }

        public ConductorCreadoDto Registrar(CrearConductorDto dto)
        {


            var existe = _repository.Consultar(dto.Nombres);

            if (existe is null)
            {

                var conductor = _mapper.Map<Conductor>(dto);
                conductor.Licenciatransito = "Registrado";
                conductor.FechaRegistro = DateTime.Now;
                conductor.Nombres = conductor.Nombres.Substring(0, 1).ToUpper() + new Random().NextInt64(1, 10000);


                var  vehiculo =  _vehiculoService.Existe(dto.IdVehiculo);

                if (vehiculo) {

            

                    // Viola el principio de ID
                    //ProductoRepository _repository = new ProductoRepository();
                    _repository.Registrar(conductor);

                    var conductorCreado = _mapper.Map<ConductorCreadoDto>(conductor);

                    return conductorCreado;
                }



            }

            return null;
        }
    }
}
