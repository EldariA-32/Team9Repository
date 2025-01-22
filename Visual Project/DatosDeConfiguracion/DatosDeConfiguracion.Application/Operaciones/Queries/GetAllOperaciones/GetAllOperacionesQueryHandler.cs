using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Queries.GetAllOperaciones
{
    public class GetAllOperacionesQueryHandler
        : IQueryHandler<GetAllOperacionesQuery, IEnumerable<Operacion>>
    {
        private readonly IOperacionRepository _operacionRepository;

        public GetAllOperacionesQueryHandler(
            IOperacionRepository operacionRepository)
        {
            _operacionRepository = operacionRepository;
        }

        public Task<IEnumerable<Operacion>> Handle(
            GetAllOperacionesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_operacionRepository.GetAllOperaciones());
        }
    }
}
