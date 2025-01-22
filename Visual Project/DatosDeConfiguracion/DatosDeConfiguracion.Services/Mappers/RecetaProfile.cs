using AutoMapper;
using Google.Protobuf.WellKnownTypes;

namespace DatosDeConfiguracion.Services.Mappers
{
    public class RecetaProfile : Profile
    {
        public RecetaProfile()
        {
            CreateMap<Domain.Entities.Receta,
                GrpcProtos.RecetaDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.ProductoId, o => o.MapFrom(s => s.ProductoId.ToString()))
                .ForMember(t => t.FechaCreacion, o => o.MapFrom(
                    s => Timestamp.FromDateTime(s.FechaCreacion.ToUniversalTime())))
                .ForMember(t => t.FechaValidacion, o => o.MapFrom(
                    s => Timestamp.FromDateTime(s.FechaValidacion.ToUniversalTime())))
                .ForMember(t => t.ExpertoValidacion, o => o.MapFrom(s => s.ExpertoValidacion));

            CreateMap<GrpcProtos.RecetaDTO,
                Domain.Entities.Receta>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.ProductoId, o => o.MapFrom(
                    s => new Guid(s.ProductoId)))
                .ForMember(t => t.FechaCreacion, o => o.MapFrom(
                    s => s.FechaCreacion.ToDateTime()))
                .ForMember(t => t.FechaValidacion, o => o.MapFrom(
                    s => s.FechaValidacion.ToDateTime()))
                .ForMember(t => t.ExpertoValidacion, o => o.MapFrom(
                    s => s.ExpertoValidacion));

        }
    }
}
