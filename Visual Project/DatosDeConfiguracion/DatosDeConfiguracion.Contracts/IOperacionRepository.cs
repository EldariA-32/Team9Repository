using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Contracts
{
    /*Describe las funcionalidades necesarias
      para dar persistencia a las operaciones*/
    public interface IOperacionRepository
    {
        // Añade una operación al soporte de datos
        void AddOperacion(Operacion operacion);

        // Obtiene una operación del soporte de datos a partir de su identificador
        Operacion? GetOperacionById(Guid id);

        // Obtiene todas las operaciones del soporte de datos
        public IEnumerable<Operacion> GetAllOperaciones();

        // Actualiza el valor de una operación en el soporte de datos
        void UpdateOperacion(Operacion operacion);

        // Elimina una operación del soporte de datos
        void DeleteOperacion(Operacion operacion);
    }
}
