using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using DatosDeConfiguracion.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Commands.CreateFase
{
    public record CreateFaseCommand(
        Guid OperacionId, string Nombre, 
        double Duracion, string Descripcion)
        : ICommand<Fase>;
}
