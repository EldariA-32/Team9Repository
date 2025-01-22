using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Commands.CreateOperacion
{
    public class CreateOperacionCommandHandler
        : ICommandHandler<CreateOperacionCommand, Operacion>
    {
        private readonly IOperacionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateOperacionCommandHandler(
            IOperacionRepository operacionRepository,
            IUnitOfWork unitOfWork)
        {
            _operacionRepository = operacionRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Operacion> Handle(
            CreateOperacionCommand request, CancellationToken cancellationToken)
        {
            Operacion result = new(
                request.Nombre,
                request.Descripcion,
                request.Unidad,
                request.RecetaId,
                Guid.NewGuid());

            _operacionRepository.AddOperacion(result);
            _unitOfWork.SaveChanges();

            return Task.FromResult(result);
        }
    }
}
