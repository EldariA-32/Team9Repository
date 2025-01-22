using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Contracts
{
    /*Describe las funcionalidades necesarias
      para dar persistencia a los productos*/
    public interface IProductoRepository
    {
        // Añade un producto al soporte de datos
        void AddProducto(Producto producto);

        // Obtiene un producto del soporte de datos a partir de su identificador
        Producto? GetProductoById(Guid id);

        // Obtiene todos los productos del soporte de datos
        public IEnumerable<Producto> GetAllProductos();

        // Actualiza el valor de un producto en el soporte de datos
        void UpdateProducto(Producto producto);

        // Elimina un producto del soporte de datos
        void DeleteProducto(Producto producto);
    }
}
