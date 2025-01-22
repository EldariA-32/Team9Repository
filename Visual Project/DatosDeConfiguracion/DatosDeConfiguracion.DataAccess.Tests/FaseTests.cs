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
using DatosDeConfiguracion.Domain.ValueObjects;

namespace DatosDeConfiguracion.DataAccess.Tests
{
    [TestClass]
    public class FaseTests
    {
        private IFaseRepository _faseRepository;
        private IOperacionRepository _operacionRepository;
        private IUnitOfWork _unitOfWork;

        public FaseTests()
        {
            ApplicationContext context =
                new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _faseRepository = new FaseRepository(context);
            _operacionRepository = new OperacionRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Fase 1", 20, "Corta")]
        [DataRow("Fase 2", 12, "Electrocuta")]
        [TestMethod]
        public void Can_Add_Fase(
            string nombre, double duracion, string descripcion)
        {
            // Arrange
            Guid id = Guid.NewGuid();
            var operaciones = _operacionRepository.GetAllOperaciones().ToList();
            Operacion operacionToGet = operaciones[0];
            Fase fase =
                new Fase(nombre, duracion, descripcion, operacionToGet.Id, id);

            // Execute
            _faseRepository.AddFase(fase);
            _unitOfWork.SaveChanges();

            // Assert
            Fase? loadedFase = _faseRepository.GetFaseById(id);
            Assert.IsNotNull(loadedFase);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Get_Fase_By_Id(int position)
        {
            // Arrange
            var fases = _faseRepository.GetAllFases().ToList();
            Assert.IsNotNull(fases);
            Assert.IsTrue(position < fases.Count);
            Fase faseToGet = fases[position];

            // Execute
            Fase? loadedFase =
                _faseRepository.GetFaseById(faseToGet.Id);

            // Assert
            Assert.IsNotNull(loadedFase);
        }

        [DataRow(0, "Fase 4", 81)]
        [TestMethod]
        public void Can_Update_Fase(int position, string descripcion, double duracion)
        {
            // Arrange
            var fases = _faseRepository.GetAllFases().ToList();
            Assert.IsNotNull(fases);
            Assert.IsTrue(position < fases.Count);
            Fase faseToUpdate = fases[position];

            // Execute
            faseToUpdate.Descripcion = descripcion;
            faseToUpdate.Duracion = duracion;
            _faseRepository.UpdateFase(faseToUpdate);
            _unitOfWork.SaveChanges();

            // Assert
            Fase? updatedFase =
                _faseRepository.GetFaseById(faseToUpdate.Id);
            Assert.IsNotNull(updatedFase);
            Assert.AreEqual(descripcion, updatedFase.Descripcion);
            Assert.AreEqual(duracion, updatedFase.Duracion);
        }

        [TestMethod]
        public void Cannot_Get_Fase_By_Invalid_Id()
        {
            // Arrange

            // Execute
            Fase? loadedFase =
                _faseRepository.GetFaseById(Guid.Empty);

            // Assert
            Assert.IsNull(loadedFase);
        }

        [DataRow(0)]
        [TestMethod]
        public void Can_Delete_Fase(int position)
        {
            // Arrange
            var fases = _faseRepository.GetAllFases().ToList();
            Assert.IsNotNull(fases);
            Assert.IsTrue(position < fases.Count);
            Fase faseToDelete = fases[position];

            // Execute
            _faseRepository.DeleteFase(faseToDelete);
            _unitOfWork.SaveChanges();

            // Assert
            Fase? deletedFase =
                _faseRepository.GetFaseById(faseToDelete.Id);
            Assert.IsNull(deletedFase);
        }
    }
}

