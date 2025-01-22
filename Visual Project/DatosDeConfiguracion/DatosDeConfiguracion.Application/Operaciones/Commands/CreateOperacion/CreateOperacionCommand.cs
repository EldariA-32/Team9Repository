using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Operaciones.Commands.CreateOperacion
{
    public record CreateOperacionCommand(
        Guid RecetaId, string Nombre, 
        string Descripcion, string Unidad) : ICommand<Operacion>;
}
