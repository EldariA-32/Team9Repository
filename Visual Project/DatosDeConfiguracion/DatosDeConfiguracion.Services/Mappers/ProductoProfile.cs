using AutoMapper;

namespace DatosDeConfiguracion.Services.Mappers
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Domain.Entities.Producto,
                GrpcProtos.ProductoDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Empresa, o => o.MapFrom(s => s.Empresa))
                .ForMember(t => t.Envase, o => o.MapFrom(s => (GrpcProtos.FormaEnvase)s.Envase));

            CreateMap<GrpcProtos.ProductoDTO,
                Domain.Entities.Producto>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Empresa, o => o.MapFrom(s => s.Empresa))
                .ForMember(t => t.Envase, o => o.MapFrom(s => (Domain.Types.FormaEnvase)s.Envase));

        }
    }
}
