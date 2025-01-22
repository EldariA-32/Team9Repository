using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Queries.GetOperacionById
{
    public class GetOperacionByIdQueryHandler
        : IQueryHandler<GetOperacionByIdQuery, Operacion?>
    {
        private readonly IOperacionRepository _operacionRepository;

        public GetOperacionByIdQueryHandler(
            IOperacionRepository operacionRepository)
        {
            _operacionRepository = operacionRepository;
        }

        public Task<Operacion?> Handle(
            GetOperacionByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_operacionRepository.GetOperacionById(request.Id));
        }
    }
}