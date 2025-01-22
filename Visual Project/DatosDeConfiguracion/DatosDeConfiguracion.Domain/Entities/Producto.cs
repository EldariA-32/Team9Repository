using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;
using DatosDeConfiguracion.Domain.Types;

namespace DatosDeConfiguracion.Domain.Entities
{
    // Producto con características específicas
    public class Producto : Entity
    {
        #region Propiedades

        // Nombre del producto
        public string Nombre { get; set; }

        // Nombre de la empresa que fabrica determinado producto
        public string Empresa { get; set; }

        // Indicador de la forma del envase en que se empaqueta un producto
        public FormaEnvase Envase { get; set; }

        // Un producto puede ser fabricado usando varias recetas
        public List<Receta> Receta { get; set; }

        #endregion

        // Constructor por defecto que requiere EntityFramework para migrar
        protected Producto() { }

        // Contructor de un producto que hereda su Id de Entity
        public Producto(string nombre, string empresa, FormaEnvase envase, Guid id)
                        : base(id)
        {
            Nombre = nombre;
            Empresa = empresa;
            Envase = envase;
            Receta = new List<Receta>();
        }
    }
}

