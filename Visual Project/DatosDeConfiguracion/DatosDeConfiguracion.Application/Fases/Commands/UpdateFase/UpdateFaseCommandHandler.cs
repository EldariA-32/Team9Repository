using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Commands.UpdateFase
{
    public class UpdateFaseCommandHandler
        : ICommandHandler<UpdateFaseCommand>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateFaseCommandHandler(
            IFaseRepository faseRepository,
            IUnitOfWork unitOfWork)
        {
            _faseRepository = faseRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            UpdateFaseCommand request, CancellationToken cancellationToken)
        {
            _faseRepository.UpdateFase(request.Fase);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
