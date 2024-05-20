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
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly DbContexto _context;
        public VehiculoRepository(DbContexto context)
        {

            _context = context;
        }

        public Vehiculo Consultar(int id)
        {
            return _context.Vehiculos.Find(id);
        }

        public Vehiculo Consultar(string Matricula)
        {
            return _context.Vehiculos.FirstOrDefault(x => x.Matricula.Equals(Matricula));
        }
        public bool Existe(int id)
        {
            return _context.Vehiculos.Any(x => x.Id == id);
        }

        public bool Registrar(Vehiculo vehiculo)
        {
            _context.Add(vehiculo);
            return _context.SaveChanges() > 0;
        }
    }
}
