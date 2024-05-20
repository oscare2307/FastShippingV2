using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaces
{
    public interface IVehiculoRepository
    {
        bool Registrar(Vehiculo vehiculo);

        Vehiculo Consultar(int id);
        Vehiculo Consultar(string matricula);

        bool Existe(int id);
    }
}
