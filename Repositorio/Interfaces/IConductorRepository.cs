using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IConductorRepository
    {
        bool Registrar(Conductor conductor);

        Conductor Consultar(int id);
        Conductor Consultar(string licenciaTransito);

    }
}
