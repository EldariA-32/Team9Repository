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
    // Implementación de IFaseRepository
    public class FaseRepository : RepositoryBase, IFaseRepository
    {
        public FaseRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddFase(Fase fase)
        {
            _context.Fases.Add(fase);
        }

        public Fase? GetFaseById(Guid id)
        {
            return _context.Fases.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Fase> GetAllFases()
        {
            return _context.Fases.ToList();
        }

        public void UpdateFase(Fase fase)
        {
            _context.Fases.Update(fase);
        }

        public void DeleteFase(Fase fase)
        {
            _context.Fases.Remove(fase);
        }
    }
}