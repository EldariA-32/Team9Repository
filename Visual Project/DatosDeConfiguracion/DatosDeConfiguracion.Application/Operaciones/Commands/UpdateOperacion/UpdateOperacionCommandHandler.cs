using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Commands.UpdateOperacion
{
    public class UpdateOperacionCommandHandler
        : ICommandHandler<UpdateOperacionCommand>
    {
        private readonly IOperacionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateOperacionCommandHandler(
            IOperacionRepository operacionRepository,
            IUnitOfWork unitOfWork)
        {
            _operacionRepository = operacionRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            UpdateOperacionCommand request, CancellationToken cancellationToken)
        {
            _operacionRepository.UpdateOperacion(request.Operacion);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
