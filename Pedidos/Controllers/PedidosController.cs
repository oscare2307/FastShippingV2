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
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Pedido> Consultar(int id)
        {
            return Ok(_pedidoService.Consultar(id));
        }

        [HttpPost]
        public ActionResult Crear([FromBody] CrearPedidoDto crearPedidoDto)
        {


            if (!String.IsNullOrEmpty(crearPedidoDto.Descripcion)
                || !String.IsNullOrEmpty(crearPedidoDto.direccionEnvio)
                || !String.IsNullOrEmpty(crearPedidoDto.direccionRecogida))
            {

                var pedidoCreado = _pedidoService.Registrar(crearPedidoDto);

                if (pedidoCreado == null)
                {
                    return BadRequest($"Ya existe un pedido con ese nombre {crearPedidoDto.Descripcion}");
                }

                return Ok(pedidoCreado);


            }
            else
            {

                return BadRequest("Error en los datos de entrada");
            }


        }

    }
}


