using DatosDeConfiguracion.DataAccess.FluentConfigurations.Common;
using DatosDeConfiguracion.Domain.Entities;
using DatosDeConfiguracion.Domain.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.DataAccess.FluentConfigurations.Entities
{
    // Configuración de los productos en BD
    public class ProductoEntityTypeConfiguration
        : EntityTypeConfigurationBase<Producto>
    {
        // Para configurar aspectos de la tabla de productos
        public override void Configure(EntityTypeBuilder<Producto> builder)
        {
            // Los productos se almacenarán en la tabla Productos
            builder.ToTable("Productos");
            // El nombre del producto es requerido para almacenarlo en BD
            builder.Property(x => x.Nombre).IsRequired();
            // Definiendo como convertir de FormaEnvase a string y viceversa
            builder.Property(x => x.Envase).HasConversion(c => c.ToString(),
                s => FormaEnvase.Parse<FormaEnvase>(s));
        }
    }
}
