using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Commands.CreateFase
{
    public class CreateFaseCommandHandler
        : ICommandHandler<CreateFaseCommand, Fase>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateFaseCommandHandler(
            IFaseRepository faseRepository,
            IUnitOfWork unitOfWork)
        {
            _faseRepository = faseRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Fase> Handle(
            CreateFaseCommand request, CancellationToken cancellationToken)
        {
            Fase result = new(
                request.Nombre,
                request.Duracion,
                request.Descripcion,
                request.OperacionId,
                Guid.NewGuid());

            _faseRepository.AddFase(result);
            _unitOfWork.SaveChanges();

            return Task.FromResult(result);
        }
    }
}
