using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Commands.DeleteReceta
{
    public class DeleteRecetaCommandHandler
        : ICommandHandler<DeleteRecetaCommand>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRecetaCommandHandler(
            IRecetaRepository recetaRepository,
            IUnitOfWork unitOfWork)
        {
            _recetaRepository = recetaRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            DeleteRecetaCommand request, CancellationToken cancellationToken)
        {
            var recetaToDelete = _recetaRepository.GetRecetaById(request.Id);
            if (recetaToDelete is null)
                return Task.CompletedTask;
            _recetaRepository.DeleteReceta(recetaToDelete);
            _unitOfWork.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
