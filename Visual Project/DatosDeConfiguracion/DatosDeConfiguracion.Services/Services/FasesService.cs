using AutoMapper;
using DatosDeConfiguracion.Application.Fases.Commands.CreateFase;
using DatosDeConfiguracion.Application.Fases.Commands.DeleteFase;
using DatosDeConfiguracion.Application.Fases.Commands.UpdateFase;
using DatosDeConfiguracion.Application.Fases.Queries.GetAllFases;
using DatosDeConfiguracion.Application.Fases.Queries.GetFaseById;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.GrpcProtos;
using DatosDeConfiguracion.Services;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;

namespace DatosDeConfiguracion.Services.Services
{
    public class FasesService : Fase.FaseBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public FasesService(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public override Task<FaseDTO> CreateFase(
            CreateFaseRequest request, ServerCallContext context)
        {
            string input = request.OperacionId;
            Guid operacionId = new(input);
            var command = new CreateFaseCommand(
                operacionId,
                request.Nombre,
                request.Duracion,
                request.Descripcion);

            var result = _mediator.Send(command).Result;

            return Task.FromResult(_mapper.Map<FaseDTO>(result));
        }


        public override Task<NullableFaseDTO> GetFase(
            GetRequest request, ServerCallContext context)
        {
            var query = new GetFaseByIdQuery(new Guid(request.Id));

            var result = _mediator.Send(query).Result;

            if (result is null)
                return Task.FromResult(new NullableFaseDTO()
                {
                    Null = NullValue.NullValue
                });
            return Task.FromResult(new NullableFaseDTO()
            {
                Fase = _mapper.Map<FaseDTO>(result)
            });
        }

        public override Task<Fases> GetAllFases(
            Empty request, ServerCallContext context)
        {
            var query = new GetAllFasesQuery();

            var result = _mediator.Send(query).Result;

            // Convirtiendo de lista de fases al mensaje de lista de DTOs de fases.
            var fasesDTOs = new Fases();
            fasesDTOs.Items.AddRange(result.Select(r => _mapper.Map<FaseDTO>(r)));

            return Task.FromResult(fasesDTOs);
        }

        public override Task<Empty> UpdateFase(
            FaseDTO request, ServerCallContext context)
        {
            var command = new UpdateFaseCommand(
                _mapper.Map<Domain.Entities.Fase>(request));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }


        public override Task<Empty> DeleteFase(
            DeleteRequest request, ServerCallContext context)
        {
            var command = new DeleteFaseCommand(new Guid(request.Id));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }
    } 
}