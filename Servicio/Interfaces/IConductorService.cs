using Dominio.Dtos;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Interfaces
{
    public interface IConductorService
    {
        ConductorCreadoDto Registrar(CrearConductorDto dto);
        Conductor Consultar(int id);
    }
}
