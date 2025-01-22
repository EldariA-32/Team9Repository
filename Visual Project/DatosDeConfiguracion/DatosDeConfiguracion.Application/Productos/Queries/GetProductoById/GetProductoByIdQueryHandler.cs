using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Queries.GetProductoById
{
    public class GetProductoByIdQueryHandler
        : IQueryHandler<GetProductoByIdQuery, Producto?>
    {
        private readonly IProductoRepository _productoRepository;

        public GetProductoByIdQueryHandler(
            IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Task<Producto?> Handle(
            GetProductoByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productoRepository.GetProductoById(request.Id));
        }
    }
}

