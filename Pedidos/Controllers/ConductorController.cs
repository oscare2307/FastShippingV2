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
    public class ConductorController : ControllerBase
    {
        private readonly IConductorService _conductorService;
        public ConductorController(IConductorService conductorService)
        {
            _conductorService = conductorService;
        }

        [HttpGet("{id}")]
        public ActionResult<Conductor> Consultar(int id)
        {
            return Ok(_conductorService.Consultar(id));
        }

        [HttpPost]
        public ActionResult Crear([FromBody] CrearConductorDto crearConductorDto)
        {


            if (!String.IsNullOrEmpty(crearConductorDto.Nombres)
                || !String.IsNullOrEmpty(crearConductorDto.Apellidos)
                || !String.IsNullOrEmpty(crearConductorDto.LicenciaTrasito))
            {

                var conductorCreado = _conductorService.Registrar(crearConductorDto);

                if (conductorCreado == null)
                {
                    return BadRequest($"Ya existe un conductor con ese nombre {crearConductorDto.LicenciaTrasito}");
                }

                return Ok(conductorCreado);


            }
            else
            {

                return BadRequest("Error en los datos de entrada");
            }


        }

    }
}