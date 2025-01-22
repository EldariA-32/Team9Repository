using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Commands.UpdateProducto
{
    public class UpdateProductoCommandHandler
        : ICommandHandler<UpdateProductoCommand>
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductoCommandHandler(
            IProductoRepository productoRepository,
            IUnitOfWork unitOfWork)
        {
            _productoRepository = productoRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            UpdateProductoCommand request, CancellationToken cancellationToken)
        {
            _productoRepository.UpdateProducto(request.Producto);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
