using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Contracts
{
    /*Define las propiedades y funcionalidades de un elemento de
      acceso a datos que utiliza el patrón Unit of Work*/ 
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
