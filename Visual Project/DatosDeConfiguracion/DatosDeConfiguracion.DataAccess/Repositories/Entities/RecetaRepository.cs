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
    // Implementación de IRecetaRepository
    public class RecetaRepository : RepositoryBase, IRecetaRepository
    {
        public RecetaRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddReceta(Receta receta)
        {
            _context.Recetas.Add(receta);
        }

        public Receta? GetRecetaById(Guid id)
        {
            return _context.Recetas.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Receta> GetAllRecetas()
        {
            return _context.Recetas.ToList();
        }

        public void UpdateReceta(Receta receta)
        {
            _context.Recetas.Update(receta);
        }

        public void DeleteReceta(Receta receta)
        {
            _context.Recetas.Remove(receta);
        }
    }
}
