using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.DataAccess.Contexts;
using DatosDeConfiguracion.DataAccess.Repositories.Common;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.DataAccess.Repositories.Entities
{
    // Implementación de IOperacionRepository
    public class OperacionRepository : RepositoryBase, IOperacionRepository
    {
        public OperacionRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddOperacion(Operacion operacion)
        {
            _context.Operaciones.Add(operacion);
        }

        public Operacion? GetOperacionById(Guid id)
        {
            return _context.Operaciones.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Operacion> GetAllOperaciones()
        {
            return _context.Operaciones.ToList();
        }

        public void UpdateOperacion(Operacion operacion)
        {
            _context.Operaciones.Update(operacion);
        }

        public void DeleteOperacion(Operacion operacion)
        {
            _context.Operaciones.Remove(operacion);
        }
    }
}

