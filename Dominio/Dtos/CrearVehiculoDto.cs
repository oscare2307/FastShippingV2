using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos
{
    public class CrearVehiculoDto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
         public int IdConductor { get; set; }

    }
}
