using AutoMapper;
using DatosDeConfiguracion.Domain.Entities;
using DatosDeConfiguracion.Domain.ValueObjects;
using DatosDeConfiguracion.GrpcProtos;

namespace DatosDeConfiguracion.Services.Mappers
{
    public class FaseProfile : Profile
    {
        private readonly IMapper _mapper;

        public FaseProfile()
        {
        }

        public FaseProfile(IMapper mapper)
        {
            _mapper = mapper;

            CreateMap<Domain.Entities.Fase,
                GrpcProtos.FaseDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.OperacionId, o => o.MapFrom(
                    s => s.OperacionId.ToString()))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Duracion, o => o.MapFrom(s => s.Duracion))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.AccionesDeControl, o => o.MapFrom(s =>
                s.AccionesDeControl.Select(
                    a => _mapper.Map<GrpcProtos.AccionDeControl>(a)).ToList()));

            CreateMap<GrpcProtos.FaseDTO,
                Domain.Entities.Fase>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.OperacionId, o => o.MapFrom(
                    s => new Guid(s.OperacionId)))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Duracion, o => o.MapFrom(s => s.Duracion))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.AccionesDeControl, o => o.MapFrom(s =>
                s.AccionesDeControl.Select(
                    a => _mapper.Map<Domain.ValueObjects.AccionDeControl>(a)).ToList()));

        }
    }
}
