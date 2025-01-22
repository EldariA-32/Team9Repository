using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Commands.DeleteFase
{
    public class DeleteFaseCommandHandler
        : ICommandHandler<DeleteFaseCommand>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFaseCommandHandler(
            IFaseRepository faseRepository,
            IUnitOfWork unitOfWork)
        {
            _faseRepository = faseRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            DeleteFaseCommand request, CancellationToken cancellationToken)
        {
            var faseToDelete = _faseRepository.GetFaseById(request.Id);
            if (faseToDelete is null)
                return Task.CompletedTask;
            _faseRepository.DeleteFase(faseToDelete);
            _unitOfWork.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
