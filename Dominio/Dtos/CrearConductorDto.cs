using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos
{
    public class CrearConductorDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaTrasito { get; set; }
        public int IdVehiculo  { get; set; }

    }
}
