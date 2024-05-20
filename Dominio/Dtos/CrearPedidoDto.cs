using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos
{
    public class CrearPedidoDto
    {
        public string Descripcion { get; set; }
        public  int Productos { get; set; }
        public string direccionEnvio { get; set; }
        public  string direccionRecogida { get; set; }
    }
}
