using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using DatosDeConfiguracion.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Commands.CreateProducto
{
    public record CreateProductoCommand(
        string Nombre, string Empresa,
        FormaEnvase Envase) : ICommand<Producto>;
}

