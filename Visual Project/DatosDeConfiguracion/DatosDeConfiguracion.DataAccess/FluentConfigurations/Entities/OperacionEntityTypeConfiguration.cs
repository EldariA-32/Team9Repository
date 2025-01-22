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
    // Configuración de las operaciones en BD
    public class OperacionEntityTypeConfiguration
        : EntityTypeConfigurationBase<Operacion>
    {
        // Para configurar aspectos de la tabla de operaciones
        public override void Configure(EntityTypeBuilder<Operacion> builder)
        {
            // Las operaciones se almacenarán en la tabla Operaciones
            builder.ToTable("Operaciones");
            // El nombre de la operación es requerido para almacenarla en BD
            builder.Property(x => x.Nombre).IsRequired();
            base.Configure(builder);
            // Relación uno a muchos entre recetas y operaciones
            builder.HasOne(x => x.Receta).WithMany()
                .HasForeignKey(x => x.RecetaId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

