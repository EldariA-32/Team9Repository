using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Fases.Queries.GetAllFases
{
    public record GetAllFasesQuery : IQuery<IEnumerable<Fase>>;
}

