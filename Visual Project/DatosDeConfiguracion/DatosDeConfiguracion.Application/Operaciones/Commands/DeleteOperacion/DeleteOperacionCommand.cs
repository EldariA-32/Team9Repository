using DatosDeConfiguracion.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Commands.DeleteOperacion
{
    public record DeleteOperacionCommand(Guid Id) : ICommand;
}
