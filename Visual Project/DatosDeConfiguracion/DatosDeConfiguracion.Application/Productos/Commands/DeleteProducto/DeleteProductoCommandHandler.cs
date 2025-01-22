using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Commands.DeleteProducto
{
    public class DeleteProductoCommandHandler
        : ICommandHandler<DeleteProductoCommand>
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductoCommandHandler(
            IProductoRepository productoRepository,
            IUnitOfWork unitOfWork)
        {
            _productoRepository = productoRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(
            DeleteProductoCommand request, CancellationToken cancellationToken)
        {
            var productoToDelete = _productoRepository.GetProductoById(request.Id);
            if (productoToDelete is null)
                return Task.CompletedTask;
            _productoRepository.DeleteProducto(productoToDelete);
            _unitOfWork.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
