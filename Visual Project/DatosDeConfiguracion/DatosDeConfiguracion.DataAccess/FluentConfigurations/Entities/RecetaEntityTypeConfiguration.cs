using DatosDeConfiguracion.DataAccess.FluentConfigurations.Common;
using DatosDeConfiguracion.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.DataAccess.FluentConfigurations.Entities
{
    // Configuración de las recetas en BD
    public class RecetaEntityTypeConfiguration
        : EntityTypeConfigurationBase<Receta>
    {
        // Para configurar aspectos de la tabla de recetas
        public override void Configure(EntityTypeBuilder<Receta> builder)
        {
            // Las recetas se almacenarán en la tabla Recetas
            builder.ToTable("Recetas");
            // La fecha de creación de la receta es requerida para almacenarla en BD
            builder.Property(x => x.FechaCreacion).IsRequired();
            base.Configure(builder);
            // Relación uno a muchos entre productos y recetas
            builder.HasOne(x => x.Producto).WithMany().
                HasForeignKey(x => x.ProductoId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
