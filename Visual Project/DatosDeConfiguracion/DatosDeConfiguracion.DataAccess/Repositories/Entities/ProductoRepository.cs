using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.DataAccess.Contexts;
using DatosDeConfiguracion.DataAccess.Repositories.Common;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.DataAccess.Repositories.Entities
{
    // Implementación de IProductoRepository
    public class ProductoRepository : RepositoryBase, IProductoRepository
    {
        public ProductoRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
        }

        public Producto? GetProductoById(Guid id)
        {
            return _context.Productos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            return _context.Productos.ToList();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Productos.Update(producto);
        }

        public void DeleteProducto(Producto producto)
        {
            _context.Productos.Remove(producto);
        }
    }
}
