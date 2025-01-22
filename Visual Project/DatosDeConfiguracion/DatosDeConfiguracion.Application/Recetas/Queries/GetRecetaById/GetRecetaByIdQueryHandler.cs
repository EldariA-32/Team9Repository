using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Queries.GetRecetaById
{
    public class GetRecetaByIdQueryHandler
        : IQueryHandler<GetRecetaByIdQuery, Receta?>
    {
        private readonly IRecetaRepository _recetaRepository;

        public GetRecetaByIdQueryHandler(
            IRecetaRepository recetaRepository)
        {
            _recetaRepository = recetaRepository;
        }

        public Task<Receta?> Handle(
            GetRecetaByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_recetaRepository.GetRecetaById(request.Id));
        }
    }
}