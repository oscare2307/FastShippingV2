using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{

    [Table("Conductores")]
    public class Conductor: EntidadBase
    {
        public int Id { get; set; }
        public  string Nombres { get; set; }
        public  string Apellidos { get; set; }
        public  string Licenciatransito { get; set; }
        public  DateOnly Fechanacimiento { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int VehiculoId {  get; set; }
    }
}
