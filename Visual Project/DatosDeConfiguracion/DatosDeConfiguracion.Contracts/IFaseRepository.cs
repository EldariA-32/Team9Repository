using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Contracts
{
    /*Describe las funcionalidades necesarias
      para dar persistencia a las fases*/
    public interface IFaseRepository
    {
        // Añade una fase al soporte de datos
        void AddFase(Fase fase);

        // Obtiene una fase del soporte de datos a partir de su identificador
        Fase? GetFaseById(Guid id);

        // Obtiene todas las fases del soporte de datos
        public IEnumerable<Fase> GetAllFases();

        // Actualiza el valor de una fase en el soporte de datos
        void UpdateFase(Fase fase);

        // Elimina una fase del soporte de datos
        void DeleteFase(Fase fase);
    }
}

