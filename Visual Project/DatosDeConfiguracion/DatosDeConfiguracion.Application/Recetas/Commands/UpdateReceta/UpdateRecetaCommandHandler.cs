using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Commands.UpdateReceta
{
    public class UpdateRecetaCommandHandler
        : ICommandHandler<UpdateRecetaCommand>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRecetaCommandHandler(
            IRecetaRepository recetaRepository,
            IUnitOfWork unitOfWork)
        {
            _recetaRepository = recetaRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            UpdateRecetaCommand request, CancellationToken cancellationToken)
        {
            _recetaRepository.UpdateReceta(request.Receta);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
