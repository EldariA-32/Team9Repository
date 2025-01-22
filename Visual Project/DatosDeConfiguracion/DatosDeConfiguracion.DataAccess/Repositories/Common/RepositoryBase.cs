using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.DataAccess.Contexts;

namespace DatosDeConfiguracion.DataAccess.Repositories.Common
{
    // Clase base para repositorios
    public abstract class RepositoryBase
    {
        // Contexto del soporte de datos
        protected ApplicationContext _context;
        protected RepositoryBase(ApplicationContext context)
        {
            _context = context;
        }
    }
}
