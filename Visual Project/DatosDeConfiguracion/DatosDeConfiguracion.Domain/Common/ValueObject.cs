using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Domain.Common
{
    // Clase base de los objetos de valor
    public abstract class ValueObject
    {
        // Para determinar que propiedades se compararán en cada objeto de valor 
        protected abstract IEnumerable<object> GetEqualityComponents();

        /* Para comprobar si dos objetos son iguales según sus propiedades
           y obviando sus referencias*/
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;
            var other = (ValueObject)obj;

            // Compara las propiedades dentro de las listas enviadas por cada objeto  
            return this.GetEqualityComponents().
                SequenceEqual(other.GetEqualityComponents());
        }
    }
}

