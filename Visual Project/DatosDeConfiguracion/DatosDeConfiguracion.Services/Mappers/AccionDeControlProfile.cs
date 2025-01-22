using AutoMapper;

namespace DatosDeConfiguracion.Services.Mappers
{
    public class AccionDeControlProfile : Profile
    {
        public AccionDeControlProfile()
        {
            CreateMap<Domain.ValueObjects.AccionDeControl,
                GrpcProtos.AccionDeControl>()
                .ForMember(t => t.AccionId, o => o.MapFrom(s => s.AccionId.ToString()))
                .ForMember(t => t.FaseId, o => o.MapFrom(s => s.FaseId.ToString()))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Magnitud, o => o.MapFrom(s => s.Magnitud))
                .ForMember(t => t.UnidadMedida, o => o.MapFrom(s => s.UnidadMedida));

            CreateMap<GrpcProtos.AccionDeControl,
                Domain.ValueObjects.AccionDeControl>()
                .ForMember(t => t.AccionId, o => o.MapFrom(s => new Guid(s.AccionId)))
                .ForMember(t => t.FaseId, o => o.MapFrom(s => new Guid(s.FaseId)))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Magnitud, o => o.MapFrom(s => s.Magnitud))
                .ForMember(t => t.UnidadMedida, o => o.MapFrom(s => s.UnidadMedida));

        }
    }
}
