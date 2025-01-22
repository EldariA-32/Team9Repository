using AutoMapper;
using DatosDeConfiguracion.Application.Operaciones.Commands.CreateOperacion;
using DatosDeConfiguracion.Application.Operaciones.Commands.DeleteOperacion;
using DatosDeConfiguracion.Application.Operaciones.Commands.UpdateOperacion;
using DatosDeConfiguracion.Application.Operaciones.Queries.GetAllOperaciones;
using DatosDeConfiguracion.Application.Operaciones.Queries.GetOperacionById;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.GrpcProtos;
using DatosDeConfiguracion.Services;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;

namespace DatosDeConfiguracion.Services.Services
{
    public class OperacionesService : Operacion.OperacionBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OperacionesService(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public override Task<OperacionDTO> CreateOperacion(
            CreateOperacionRequest request, ServerCallContext context)
        {
            string input = request.RecetaId;
            Guid recetaId = new(input);
            var command = new CreateOperacionCommand(
                recetaId,
                request.Nombre,
                request.Descripcion,
                request.Unidad);

            var result = _mediator.Send(command).Result;

            return Task.FromResult(_mapper.Map<OperacionDTO>(result));
        }


        public override Task<NullableOperacionDTO> GetOperacion(
            GetRequest request, ServerCallContext context)
        {
            var query = new GetOperacionByIdQuery(new Guid(request.Id));

            var result = _mediator.Send(query).Result;

            if (result is null)
                return Task.FromResult(new NullableOperacionDTO()
                {
                    Null = NullValue.NullValue
                });
            return Task.FromResult(new NullableOperacionDTO()
            {
                Operacion = _mapper.Map<OperacionDTO>(result)
            });
        }

        public override Task<Operaciones> GetAllOperaciones(
            Empty request, ServerCallContext context)
        {
            var query = new GetAllOperacionesQuery();

            var result = _mediator.Send(query).Result;

            /* Convirtiendo de lista de operaciones
              al mensaje de lista de DTOs de operaciones */
            var operacionesDTOs = new Operaciones();
            operacionesDTOs.Items.AddRange(result.Select(o => _mapper.Map<OperacionDTO>(o)));

            return Task.FromResult(operacionesDTOs);
        }

        public override Task<Empty> UpdateOperacion(
            OperacionDTO request, ServerCallContext context)
        {
            var command = new UpdateOperacionCommand(
                _mapper.Map<Domain.Entities.Operacion>(request));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }


        public override Task<Empty> DeleteOperacion(
            DeleteRequest request, ServerCallContext context)
        {
            var command = new DeleteOperacionCommand(new Guid(request.Id));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }
    }
}

