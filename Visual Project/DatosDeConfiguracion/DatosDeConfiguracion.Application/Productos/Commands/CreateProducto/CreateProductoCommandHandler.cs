using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Commands.CreateProducto
{
    public class CreateProductoCommandHandler
        : ICommandHandler<CreateProductoCommand, Producto>
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductoCommandHandler(
            IProductoRepository productoRepository,
            IUnitOfWork unitOfWork)
        {
            _productoRepository = productoRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Producto> Handle(
            CreateProductoCommand request, CancellationToken cancellationToken)
        {
            Producto result = new(
                request.Nombre,
                request.Empresa,
                request.Envase,
                Guid.NewGuid());

            _productoRepository.AddProducto(result);
            _unitOfWork.SaveChanges();

            return Task.FromResult(result);
        }
    }
}
