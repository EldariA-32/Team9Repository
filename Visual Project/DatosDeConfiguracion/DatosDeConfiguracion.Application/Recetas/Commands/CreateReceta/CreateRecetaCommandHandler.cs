using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Commands.CreateReceta
{
    public class CreateRecetaCommandHandler
        : ICommandHandler<CreateRecetaCommand, Receta>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateRecetaCommandHandler(
            IRecetaRepository recetaRepository,
            IUnitOfWork unitOfWork)
        {
            _recetaRepository = recetaRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Receta> Handle(
            CreateRecetaCommand request, CancellationToken cancellationToken)
        {
            Receta result = new(
                request.FechaValidacion,
                request.ExpertoValidacion,
                request.ProductoId,
                Guid.NewGuid());

            _recetaRepository.AddReceta(result);
            _unitOfWork.SaveChanges();

            return Task.FromResult(result);
        }
    }
}
