using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.DataAccess.Contexts;
using DatosDeConfiguracion.DataAccess.Tests.Utilities;
using DatosDeConfiguracion.DataAccess.Repositories.Entities;
using DatosDeConfiguracion.Domain.Types;
using DatosDeConfiguracion.Domain.Entities;

namespace DatosDeConfiguracion.DataAccess.Tests
{
    [TestClass]
    public class ProductoTests
    {
        private IProductoRepository _productoRepository;
        private IUnitOfWork _unitOfWork;

        public ProductoTests()
        {
            ApplicationContext context =
                new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _productoRepository = new ProductoRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Lapiz", "Lapices S.A", FormaEnvase.Caja)]
        [DataRow("Vino", "Viñales", FormaEnvase.Botella)]
        [TestMethod]
        public void Can_Add_Producto(
            string nombre, string empresa, FormaEnvase formaEnvase)
        {
            // Arrange
            Guid id = Guid.NewGuid();
            Producto producto = new Producto(nombre, empresa, formaEnvase, id);

            // Execute
            _productoRepository.AddProducto(producto);
            _unitOfWork.SaveChanges();

            // Assert
            Producto? loadedProducto = _productoRepository.GetProductoById(id);
            Assert.IsNotNull(loadedProducto);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Get_Producto_By_Id(int position)
        {
            // Arrange
            var productos = _productoRepository.GetAllProductos().ToList();
            Assert.IsNotNull(productos);
            Assert.IsTrue(position < productos.Count);
            Producto productoToGet = productos[position];

            // Execute
            Producto? loadedProducto =
                _productoRepository.GetProductoById(productoToGet.Id);

            // Assert
            Assert.IsNotNull(loadedProducto);
        }

        [DataRow(0, "Diego")]
        [TestMethod]
        public void Can_Update_Producto(int position, string nombre)
        {
            // Arrange
            var productos = _productoRepository.GetAllProductos().ToList();
            Assert.IsNotNull(productos);
            Assert.IsTrue(position < productos.Count);
            Producto productoToUpdate = productos[position];

            // Execute
            productoToUpdate.Nombre = nombre;
            _productoRepository.UpdateProducto(productoToUpdate);
            _unitOfWork.SaveChanges();

            // Assert
            Producto? updatedProducto =
                _productoRepository.GetProductoById(productoToUpdate.Id);
            Assert.IsNotNull(updatedProducto);
            Assert.AreEqual(nombre, updatedProducto.Nombre);
        }

        [TestMethod]
        public void Cannot_Get_Producto_By_Invalid_Id()
        {
            // Arrange

            // Execute
            Producto? loadedProducto = _productoRepository.GetProductoById(Guid.Empty);

            // Assert
            Assert.IsNull(loadedProducto);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Delete_Producto(int position)
        {
            // Arrange
            var productos = _productoRepository.GetAllProductos().ToList();
            Assert.IsNotNull(productos);
            Assert.IsTrue(position < productos.Count);
            Producto productoToDelete = productos[position];

            // Execute
            _productoRepository.DeleteProducto(productoToDelete);
            _unitOfWork.SaveChanges();

            // Assert
            Producto? deletedProducto =
                _productoRepository.GetProductoById(productoToDelete.Id);
            Assert.IsNull(deletedProducto);
        }
    }
}
