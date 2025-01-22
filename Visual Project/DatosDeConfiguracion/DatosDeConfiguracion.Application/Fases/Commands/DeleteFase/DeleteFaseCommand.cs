using DatosDeConfiguracion.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Commands.DeleteFase
{
    public record DeleteFaseCommand(Guid Id) : ICommand;
}

