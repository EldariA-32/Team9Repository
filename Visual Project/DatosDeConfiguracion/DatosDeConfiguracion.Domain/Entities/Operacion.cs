using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;

namespace DatosDeConfiguracion.Domain.Entities
{
    //Operación de una receta
    public class Operacion : Entity
    {
        #region Propiedades

        // Nombre de la operación
        public string Nombre { get; set; }

        // Descripción de la operación 
        public string Descripcion { get; set; }

        // Nombre de la unidad sobre la que actúa la operación 
        public string Unidad { get; set; }

        // Una operación presenta un conjunto de fases asociadas
        public List<Fase> Fases { get; set; }

        // Una operación le pertenece a una receta
        public Guid RecetaId { get; set; }
        public Receta Receta { get; set; }

        #endregion

        // Constructor por defecto que requiere EntityFramework para migrar
        protected Operacion() { }

        // Contructor de una operacion que hereda su Id de Entity
        public Operacion(string nombre, string descripcion,
            string unidad, Guid recetaId, Guid id) : base(id)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Unidad = unidad;
            RecetaId = recetaId;
            Fases = new List<Fase>();
        }
    }
}
