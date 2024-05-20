using Dominio.Dtos;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Interfaces
{
    public interface IVehiculoService
    {
        VehiculoCreadoDto Registrar(CrearVehiculoDto dto);
        Vehiculo Consultar(int id);

        bool Existe(int id);
    }
}
