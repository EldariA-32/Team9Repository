using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;
using DatosDeConfiguracion.Domain.Entities;

namespace DatosDeConfiguracion.Domain.ValueObjects
{
    // Acción de control que pertenece a una fase
    public class AccionDeControl : ValueObject
    {
        #region Propiedades

        // Nombre que describe la acción de control
        public string Nombre { get; set; }

        // Magnitud de determinada unidad de medida 
        public double Magnitud { get; set; }

        // Unidad de medida de la acción
        public string UnidadMedida { get; set; }

        // Id de la acción de control
        public Guid AccionId { get; set; }

        // Una acción de control pertenece a una fase
        public Guid FaseId { get; set; }
        public Fase Fase { get; set; }
        #endregion

        // Constructor por defecto que requiere EntityFramework para migrar
        protected AccionDeControl() { }

        // Contructor de una acción de control
        public AccionDeControl(string nombre, double magnitud,
            string unidadMedida, Guid faseId, Guid accionId)
        {
            Nombre = nombre;
            Magnitud = magnitud;
            UnidadMedida = unidadMedida;
            AccionId = accionId;
            FaseId = faseId;
        }

        /*Se determina que dos acciones de control son iguales
          si son iguales sus respectivos nombres, magnitudes y unidades de medida*/
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Nombre;
            yield return Magnitud;
            yield return UnidadMedida;
        }
    }
}

