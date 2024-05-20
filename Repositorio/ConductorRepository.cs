using Repositorio.Interfaces;
using Dominio.Entities;
using Repositorio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Dtos;

namespace Repositorio
{
    public class ConductorRepository : IConductorRepository
    {
        private readonly DbContexto _context;
        public ConductorRepository(DbContexto context)
        {

            _context = context;
        }

        public Conductor Consultar(int id)
        {
            return _context.Conductores.Find(id);
        }

        public Conductor Consultar(string licenciaTransito)
        {
            return _context.Conductores.FirstOrDefault(x => x.Licenciatransito.Equals(licenciaTransito));
        }


        public bool Registrar(Conductor conductor)
        {
            _context.Add(conductor);
            return _context.SaveChanges() > 0;
        }
    }
}