using DatosDeConfiguracion.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Commands.DeleteReceta
{
    public record DeleteRecetaCommand(Guid Id) : ICommand;
}
