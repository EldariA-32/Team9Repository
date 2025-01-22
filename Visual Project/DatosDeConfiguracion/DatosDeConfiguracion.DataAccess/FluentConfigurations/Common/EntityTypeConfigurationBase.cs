using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatosDeConfiguracion.DataAccess.FluentConfigurations.Common
{
    // Clase base para configurar Entity en BD
    public abstract class EntityTypeConfigurationBase<T>
        : IEntityTypeConfiguration<T>
        where T : Entity
    {
        // Para configurar las tablas en BD
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Todas las entidades tienen llave primaria en Id
            builder.HasKey(x => x.Id);
            // Es necesario el Id para almacenar la entidad en BD
            builder.Property(x => x.Id).IsRequired();
        }
    }
}
