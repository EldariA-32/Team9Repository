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
    public class RecetaTests
    {
        private IRecetaRepository _recetaRepository;
        private IProductoRepository _productoRepository;
        private IUnitOfWork _unitOfWork;

        public RecetaTests()
        {
            ApplicationContext context =
                new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _recetaRepository = new RecetaRepository(context);
            _productoRepository = new ProductoRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Manuel")]
        [DataRow("Alfonso")]
        [TestMethod]
        public void Can_Add_Receta(string experto)
        {
            // Arrange
            Guid id = Guid.NewGuid();
            DateTime fechaValidacion = DateTime.Now;
            var productos = _productoRepository.GetAllProductos().ToList();
            Producto productoToGet = productos[0];
            Receta receta =
                new Receta(fechaValidacion, experto, productoToGet.Id, id);

            // Execute
            _recetaRepository.AddReceta(receta);
            _unitOfWork.SaveChanges();

            // Assert
            Receta? loadedReceta = _recetaRepository.GetRecetaById(id);
            Assert.IsNotNull(loadedReceta);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Get_Receta_By_Id(int position)
        {
            // Arrange
            var recetas = _recetaRepository.GetAllRecetas().ToList();
            Assert.IsNotNull(recetas);
            Assert.IsTrue(position < recetas.Count);
            Receta recetaToGet = recetas[position];

            // Execute
            Receta? loadedReceta =
                _recetaRepository.GetRecetaById(recetaToGet.Id);

            // Assert
            Assert.IsNotNull(loadedReceta);
        }

        [DataRow(0, "Julio")]
        [TestMethod]
        public void Can_Update_Receta(int position, string experto)
        {
            // Arrange
            var recetas = _recetaRepository.GetAllRecetas().ToList();
            Assert.IsNotNull(recetas);
            Assert.IsTrue(position < recetas.Count);
            Receta recetaToUpdate = recetas[position];
            DateTime fechaValidacion = DateTime.Today.AddDays(1);

            // Execute
            recetaToUpdate.ExpertoValidacion = experto;
            recetaToUpdate.FechaValidacion = fechaValidacion;
            _recetaRepository.UpdateReceta(recetaToUpdate);
            _unitOfWork.SaveChanges();

            // Assert
            Receta? updatedReceta =
                _recetaRepository.GetRecetaById(recetaToUpdate.Id);
            Assert.IsNotNull(updatedReceta);
            Assert.AreEqual(experto, updatedReceta.ExpertoValidacion);
            Assert.AreEqual(fechaValidacion, updatedReceta.FechaValidacion);
        }

        [TestMethod]
        public void Cannot_Get_Receta_By_Invalid_Id()
        {
            // Arrange

            // Execute
            Receta? loadedReceta = _recetaRepository.GetRecetaById(Guid.Empty);

            // Assert
            Assert.IsNull(loadedReceta);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Delete_Receta(int position)
        {
            // Arrange
            var recetas = _recetaRepository.GetAllRecetas().ToList();
            Assert.IsNotNull(recetas);
            Assert.IsTrue(position < recetas.Count);
            Receta recetaToDelete = recetas[position];

            // Execute
            _recetaRepository.DeleteReceta(recetaToDelete);
            _unitOfWork.SaveChanges();

            // Assert
            Receta? deletedReceta =
                _recetaRepository.GetRecetaById(recetaToDelete.Id);
            Assert.IsNull(deletedReceta);
        }
    }
}
