using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Recetas.Commands.CreateReceta
{
    public record CreateRecetaCommand(Guid ProductoId,
        DateTime FechaValidacion,
        string ExpertoValidacion) : ICommand<Receta>;

}
