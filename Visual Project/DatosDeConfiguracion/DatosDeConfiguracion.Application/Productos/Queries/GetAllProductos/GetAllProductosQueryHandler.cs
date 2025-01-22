using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Queries.GetAllProductos
{
    public class GetAllProductosQueryHandler
        : IQueryHandler<GetAllProductosQuery, IEnumerable<Producto>>
    {
        private readonly IProductoRepository _productoRepository;

        public GetAllProductosQueryHandler(
            IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Task<IEnumerable<Producto>> Handle(
            GetAllProductosQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_productoRepository.GetAllProductos());
        }
    }
}
