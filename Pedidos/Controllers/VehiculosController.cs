using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Dominio.Entities;
using Dominio.Dtos;
using Repositorio.Data;
using Servicio;
using Servicio.Interfaces;
namespace Pedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService _vehiculoService;
        public VehiculoController(IVehiculoService vehiculoService)
        {
            _vehiculoService = vehiculoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Vehiculo> Consultar(int id)
        {
            return Ok(_vehiculoService.Consultar(id));
        }

        [HttpPost]
        public ActionResult Crear([FromBody] CrearVehiculoDto crearVehiculoDto)
        {


            if (!String.IsNullOrEmpty(crearVehiculoDto.Marca)
                || !String.IsNullOrEmpty(crearVehiculoDto.Modelo)
                || !String.IsNullOrEmpty(crearVehiculoDto.Matricula))
            {

                var vehiculoCreado = _vehiculoService.Registrar(crearVehiculoDto);

                if (vehiculoCreado == null)
                {
                    return BadRequest($"Ya existe un producto de nombre {crearVehiculoDto.Matricula}");
                }

                return Ok(vehiculoCreado);


            }
            else
            {

                return BadRequest("Error en los datos de entrada");
            }


        }

    }
}

