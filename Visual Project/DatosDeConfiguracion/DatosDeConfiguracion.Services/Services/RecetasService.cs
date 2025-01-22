using AutoMapper;
using DatosDeConfiguracion.Application.Recetas.Commands.CreateReceta;
using DatosDeConfiguracion.Application.Recetas.Commands.DeleteReceta;
using DatosDeConfiguracion.Application.Recetas.Commands.UpdateReceta;
using DatosDeConfiguracion.Application.Recetas.Queries.GetAllRecetas;
using DatosDeConfiguracion.Application.Recetas.Queries.GetRecetaById;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.GrpcProtos;
using DatosDeConfiguracion.Services;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;

namespace DatosDeConfiguracion.Services.Services
{
    public class RecetasService : Receta.RecetaBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RecetasService(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public override Task<RecetaDTO> CreateReceta(
            CreateRecetaRequest request, ServerCallContext context)
        {
            string input = request.ProductoId;
            Guid productoId = new(input);
            var command = new CreateRecetaCommand(
                productoId,
                request.FechaValidacion.ToDateTime(),
                request.ExpertoValidacion);

            var result = _mediator.Send(command).Result;

            return Task.FromResult(_mapper.Map<RecetaDTO>(result));
        }


        public override Task<NullableRecetaDTO> GetReceta(
            GetRequest request, ServerCallContext context)
        {
            var query = new GetRecetaByIdQuery(new Guid(request.Id));

            var result = _mediator.Send(query).Result;

            if (result is null)
                return Task.FromResult(new NullableRecetaDTO() { 
                    Null = NullValue.NullValue });
            return Task.FromResult(new NullableRecetaDTO() { 
                Receta = _mapper.Map<RecetaDTO>(result) });
        }

        public override Task<Recetas> GetAllRecetas(
            Empty request, ServerCallContext context)
        {
            var query = new GetAllRecetasQuery();

            var result = _mediator.Send(query).Result;

            // Convirtiendo de lista de recetas al mensaje de lista de DTOs de recetas.
            var recetasDTOs = new Recetas();
            recetasDTOs.Items.AddRange(result.Select(r => _mapper.Map<RecetaDTO>(r)));

            return Task.FromResult(recetasDTOs);
        }

        public override Task<Empty> UpdateReceta(
            RecetaDTO request, ServerCallContext context)
        {
            var command = new UpdateRecetaCommand(
                _mapper.Map<Domain.Entities.Receta>(request));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }


        public override Task<Empty> DeleteReceta(
            DeleteRequest request, ServerCallContext context)
        {
            var command = new DeleteRecetaCommand(new Guid(request.Id));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }
    }
}

