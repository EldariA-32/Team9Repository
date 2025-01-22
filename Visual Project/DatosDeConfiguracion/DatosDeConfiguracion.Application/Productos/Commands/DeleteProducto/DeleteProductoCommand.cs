using DatosDeConfiguracion.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Commands.DeleteProducto
{
    public record DeleteProductoCommand(Guid Id) : ICommand;
}

