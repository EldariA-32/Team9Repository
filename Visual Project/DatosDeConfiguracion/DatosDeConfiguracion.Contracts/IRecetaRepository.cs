using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Contracts
{
    /*Describe las funcionalidades necesarias
      para dar persistencia a las recetas*/
    public interface IRecetaRepository
    {
        // Añade una receta al soporte de datos
        void AddReceta(Receta receta);

        // Obtiene una receta del soporte de datos a partir de su identificador
        Receta? GetRecetaById(Guid id);

        // Obtiene todas las recetas del soporte de datos
        public IEnumerable<Receta> GetAllRecetas();

        // Actualiza el valor de una receta en el soporte de datos
        void UpdateReceta(Receta receta);

        // Elimina una receta del soporte de datos
        void DeleteReceta(Receta receta);
    }
}

