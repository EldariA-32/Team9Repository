using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Queries.GetAllRecetas
{
    public class GetAllRecetasQueryHandler
        : IQueryHandler<GetAllRecetasQuery, IEnumerable<Receta>>
    {
        private readonly IRecetaRepository _recetaRepository;

        public GetAllRecetasQueryHandler(
            IRecetaRepository recetaRepository)
        {
            _recetaRepository = recetaRepository;
        }

        public Task<IEnumerable<Receta>> Handle(
            GetAllRecetasQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_recetaRepository.GetAllRecetas());
        }
    }
}
