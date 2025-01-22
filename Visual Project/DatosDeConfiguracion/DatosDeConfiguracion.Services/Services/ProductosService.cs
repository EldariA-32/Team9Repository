using AutoMapper;
using DatosDeConfiguracion.Application.Productos.Commands.CreateProducto;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.GrpcProtos;
using DatosDeConfiguracion.Services;
using Google.Protobuf.WellKnownTypes;
using DatosDeConfiguracion.Domain.Types;
using Grpc.Core;
using MediatR;
using DatosDeConfiguracion.Application.Productos.Queries.GetProductoById;
using DatosDeConfiguracion.Application.Productos.Queries.GetAllProductos;
using DatosDeConfiguracion.Application.Productos.Commands.UpdateProducto;
using DatosDeConfiguracion.Application.Productos.Commands.DeleteProducto;

namespace DatosDeConfiguracion.Services.Services
{
    public class ProductosService : Producto.ProductoBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductosService(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public override Task<ProductoDTO> CreateProducto(
            CreateProductoRequest request, ServerCallContext context)
        {
            var command = new CreateProductoCommand(
                request.Nombre,
                request.Empresa,
                (Domain.Types.FormaEnvase)request.Envase);

            var result = _mediator.Send(command).Result;

            return Task.FromResult(_mapper.Map<ProductoDTO>(result));
        }


        public override Task<NullableProductoDTO> GetProducto(
            GetRequest request, ServerCallContext context)
        {
            var query = new GetProductoByIdQuery(new Guid(request.Id));

            var result = _mediator.Send(query).Result;

            if (result is null)
                return Task.FromResult(new NullableProductoDTO()
                {
                    Null = NullValue.NullValue
                });
            return Task.FromResult(new NullableProductoDTO()
            {
                Producto = _mapper.Map<ProductoDTO>(result)
            });
        }

        public override Task<Productos> GetAllProductos(
            Empty request, ServerCallContext context)
        {
            var query = new GetAllProductosQuery();

            var result = _mediator.Send(query).Result;

            /* Convirtiendo de lista de productos 
               al mensaje de lista de DTOs de productos. */
            var productosDTOs = new Productos();
            productosDTOs.Items.AddRange(result.Select(p => _mapper.Map<ProductoDTO>(p)));

            return Task.FromResult(productosDTOs);
        }

        public override Task<Empty> UpdateProducto(
            ProductoDTO request, ServerCallContext context)
        {
            var command = new UpdateProductoCommand(
                _mapper.Map<Domain.Entities.Producto>(request));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }


        public override Task<Empty> DeleteProducto(
            DeleteRequest request, ServerCallContext context)
        {
            var command = new DeleteProductoCommand(new Guid(request.Id));

            _mediator.Send(command);

            return Task.FromResult(new Empty());
        }
    }
}
