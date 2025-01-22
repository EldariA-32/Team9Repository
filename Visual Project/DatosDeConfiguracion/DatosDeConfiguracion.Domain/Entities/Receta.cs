using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;
using DatosDeConfiguracion.Domain.ValueObjects;

namespace DatosDeConfiguracion.Domain.Entities
{
    // Receta para crear un producto
    public class Receta : Entity
    {
        #region Propiedades

        // Fecha de crreación de una receta
        public DateTime FechaCreacion { get; set; }

        // Fecha de validación de una receta
        public DateTime FechaValidacion { get; set; }

        // Nombre del Experto que validó la receta
        public string ExpertoValidacion { get; set; }

        // Una receta tiene un conjunto de operaciones asociadas
        public List<Operacion> Operaciones { get; set; }

        // Una receta se usa para crear un producto específico
        public Guid ProductoId { get; set; }
        public Producto Producto { get; set; }

        #endregion

        // Constructor por defecto que requiere EntityFramework para migrar
        protected Receta() { }

        // Contructor de una receta que hereda su Id de Entity
        public Receta(DateTime fechaValidacion,
        string expertoValidacion, Guid productoId, Guid id) : base(id)
        {
            FechaCreacion = DateTime.Now; /* La fecha de creación será cuando
                                             se cree la receta por primera vez*/
                                          
            FechaValidacion = fechaValidacion;
            ExpertoValidacion = expertoValidacion;
            ProductoId = productoId;
            Operaciones = new List<Operacion>();
        }
    }
}
