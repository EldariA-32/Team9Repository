using DatosDeConfiguracion.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;

namespace DatosDeConfiguracion.Domain.Entities
{
    // Fase de una operación
    public class Fase : Entity
    {
        #region Propiedades

        // Nombre de la fase
        public string Nombre { get; set; }

        // Duración de la fase en segundos
        public double Duracion { get; set; }

        // Descripción de la fase
        public string Descripcion { get; set; }

        // Conjunto de Acciones de Control de la fase
        public List<AccionDeControl> AccionesDeControl { get; set; }

        // Una fase pertenece a solo una operación
        public Guid OperacionId { get; set; }
        public Operacion Operacion { get; set; }

        #endregion

        // Constructor por defecto que requiere EntityFramework para migrar 
        protected Fase() { }

        // Contructor de una fase que hereda su Id de Entity
        public Fase(string nombre, double duracion,
            string descripcion, Guid operacionId, Guid id) : base(id)
        {
            Nombre = nombre;
            Duracion = duracion;
            Descripcion = descripcion;
            OperacionId = operacionId;
            AccionesDeControl = new List<AccionDeControl>();
        }
    }
}

