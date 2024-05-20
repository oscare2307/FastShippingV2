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
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> Consultar(int id)
        {
            return Ok(_productoService.Consultar(id));
        }

        [HttpPost]
        public ActionResult Crear([FromBody] CrearProductoDto crearProductoDto)
        {


            if (!String.IsNullOrEmpty(crearProductoDto.Categoria)
                || !String.IsNullOrEmpty(crearProductoDto.Marca)
                || !String.IsNullOrEmpty(crearProductoDto.Descripcion))
            {

                var productoCreado = _productoService.Registrar(crearProductoDto);

                if (productoCreado == null)
                {
                    return BadRequest($"Ya existe un producto de nombre {crearProductoDto.Descripcion}");
                }

                return Ok(productoCreado);


            }
            else
            {

                return BadRequest("Error en los datos de entrada");
            }


        }

    }
}
