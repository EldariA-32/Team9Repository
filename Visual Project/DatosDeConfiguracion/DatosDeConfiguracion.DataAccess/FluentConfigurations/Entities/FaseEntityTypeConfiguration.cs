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
    // Configuración de las fases en BD
    public class FaseEntityTypeConfiguration
        : EntityTypeConfigurationBase<Fase>
    {
        // Para configurar aspectos de la tabla de fases
        public override void Configure(EntityTypeBuilder<Fase> builder)
        {
            // Las fases se almacenarán en la tabla Fases
            builder.ToTable("Fases");
            // El nombre de la fase es requerido para almacenarla en BD
            builder.Property(x => x.Nombre).IsRequired();
            base.Configure(builder);
            // Relación uno a muchos entre operaciones y fases
            builder.HasOne(x => x.Operacion).WithMany().
                HasForeignKey(x => x.OperacionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

