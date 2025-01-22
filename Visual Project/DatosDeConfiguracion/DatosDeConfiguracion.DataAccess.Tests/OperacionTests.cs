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
    public class OperacionTests
    {
        private IOperacionRepository _operacionRepository;
        private IRecetaRepository _recetaRepository;
        private IUnitOfWork _unitOfWork;

        public OperacionTests()
        {
            ApplicationContext context =
                new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _operacionRepository = new OperacionRepository(context);
            _recetaRepository = new RecetaRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Fula", "Fuego", "LaPara")]
        [DataRow("Assassins", "Creed", "Revelations")]
        [TestMethod]
        public void Can_Add_Operacion(
            string nombre, string descripcion, string unidad)
        {
            // Arrange
            Guid id = Guid.NewGuid();
            var recetas = _recetaRepository.GetAllRecetas().ToList();
            Receta recetaToGet = recetas[0];
            Operacion operacion =
                new Operacion(nombre, descripcion, unidad, recetaToGet.Id, id);

            // Execute
            _operacionRepository.AddOperacion(operacion);
            _unitOfWork.SaveChanges();

            // Assert
            Operacion? loadedOperacion = _operacionRepository.GetOperacionById(id);
            Assert.IsNotNull(loadedOperacion);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Get_Operacion_By_Id(int position)
        {
            // Arrange
            var operaciones = _operacionRepository.GetAllOperaciones().ToList();
            Assert.IsNotNull(operaciones);
            Assert.IsTrue(position < operaciones.Count);
            Operacion operacionToGet = operaciones[position];

            // Execute
            Operacion? loadedOperacion =
                _operacionRepository.GetOperacionById(operacionToGet.Id);

            // Assert
            Assert.IsNotNull(loadedOperacion);
        }

        [DataRow(0, "La nueva era")]
        [TestMethod]
        public void Can_Update_Operacion(int position, string descripcion)
        {
            // Arrange
            var operaciones = _operacionRepository.GetAllOperaciones().ToList();
            Assert.IsNotNull(operaciones);
            Assert.IsTrue(position < operaciones.Count);
            Operacion operacionToUpdate = operaciones[position];

            // Execute
            operacionToUpdate.Descripcion = descripcion;
            _operacionRepository.UpdateOperacion(operacionToUpdate);
            _unitOfWork.SaveChanges();

            // Assert
            Operacion? updatedOperacion =
                _operacionRepository.GetOperacionById(operacionToUpdate.Id);
            Assert.IsNotNull(updatedOperacion);
            Assert.AreEqual(descripcion, updatedOperacion.Descripcion);
        }

        [TestMethod]
        public void Cannot_Get_Operacion_By_Invalid_Id()
        {
            // Arrange

            // Execute
            Operacion? loadedOperacion =
                _operacionRepository.GetOperacionById(Guid.Empty);

            // Assert
            Assert.IsNull(loadedOperacion);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Delete_Operacion(int position)
        {
            // Arrange
            var operaciones = _operacionRepository.GetAllOperaciones().ToList();
            Assert.IsNotNull(operaciones);
            Assert.IsTrue(position < operaciones.Count);
            Operacion operacionToDelete = operaciones[position];

            // Execute
            _operacionRepository.DeleteOperacion(operacionToDelete);
            _unitOfWork.SaveChanges();

            // Assert
            Operacion? deletedOperacion =
                _operacionRepository.GetOperacionById(operacionToDelete.Id);
            Assert.IsNull(deletedOperacion);
        }
    }
}

