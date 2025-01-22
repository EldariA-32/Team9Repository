using AutoMapper;

namespace DatosDeConfiguracion.Services.Mappers
{
    public class OperacionProfile : Profile
    {
        public OperacionProfile()
        {
            CreateMap<Domain.Entities.Operacion,
                GrpcProtos.OperacionDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.RecetaId, o => o.MapFrom(s => s.RecetaId.ToString()))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.Unidad, o => o.MapFrom(s => s.Unidad));

            CreateMap<GrpcProtos.OperacionDTO,
                Domain.Entities.Operacion>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.RecetaId, o => o.MapFrom(s => new Guid(s.RecetaId)))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.Unidad, o => o.MapFrom(s => s.Unidad));

        }
    }
}
