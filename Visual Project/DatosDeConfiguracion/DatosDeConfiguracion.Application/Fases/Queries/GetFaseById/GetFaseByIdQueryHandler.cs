using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Queries.GetFaseById
{
    public class GetFaseByIdQueryHandler
        : IQueryHandler<GetFaseByIdQuery, Fase?>
    {
        private readonly IFaseRepository _faseRepository;

        public GetFaseByIdQueryHandler(
            IFaseRepository faseRepository)
        {
            _faseRepository = faseRepository;
        }

        public Task<Fase?> Handle(
            GetFaseByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_faseRepository.GetFaseById(request.Id));
        }
    }
}
