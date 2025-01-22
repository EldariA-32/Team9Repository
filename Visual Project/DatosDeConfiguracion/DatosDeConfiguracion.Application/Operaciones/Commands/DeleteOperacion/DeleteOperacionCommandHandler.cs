using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Commands.DeleteOperacion
{
    public class DeleteOperacionCommandHandler
        : ICommandHandler<DeleteOperacionCommand>
    {
        private readonly IOperacionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteOperacionCommandHandler(
            IOperacionRepository operacionRepository,
            IUnitOfWork unitOfWork)
        {
            _operacionRepository = operacionRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            DeleteOperacionCommand request, CancellationToken cancellationToken)
        {
            var operacionToDelete = _operacionRepository.GetOperacionById(request.Id);
            if (operacionToDelete is null)
                return Task.CompletedTask;
            _operacionRepository.DeleteOperacion(operacionToDelete);
            _unitOfWork.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
