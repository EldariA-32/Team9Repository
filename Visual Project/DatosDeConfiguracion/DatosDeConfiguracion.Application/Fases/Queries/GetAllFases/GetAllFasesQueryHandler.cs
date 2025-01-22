using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Queries.GetAllFases
{
    public class GetAllFasesQueryHandler
        : IQueryHandler<GetAllFasesQuery, IEnumerable<Fase>>
    {
        private readonly IFaseRepository _faseRepository;

        public GetAllFasesQueryHandler(
            IFaseRepository faseRepository)
        {
            _faseRepository = faseRepository;
        }

        public Task<IEnumerable<Fase>> Handle(
            GetAllFasesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_faseRepository.GetAllFases());
        }
    }
}
