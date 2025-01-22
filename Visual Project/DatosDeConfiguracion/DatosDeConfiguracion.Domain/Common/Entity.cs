using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Domain.Common
{
    // Clase base para todas las entidades
    public abstract class Entity
    {
        // Identificador de las entidades
        public Guid Id { get; set; }

        // Requerido por EntityFrameWork para migrar 
        protected Entity() { }

        // Constructor de Entity
        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}

