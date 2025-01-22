﻿using DatosDeConfiguracion.Application.Abstract;
using DatosDeConfiguracion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.Application.Productos.Queries.GetProductoById
{
    public record GetProductoByIdQuery(Guid Id) : IQuery<Producto?>;
}

