using DatosDeConfiguracion.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDeConfiguracion.Domain.ValueObjects;

namespace DatosDeConfiguracion.DataAccess.Contexts
{
    // Contexto de nuestra base de datos 
    public class ApplicationContext : DbContext
    {
        #region Tables

        // Tabla de productos
        public DbSet<Producto> Productos { get; set; }

        // Tabla de recetas
        public DbSet<Receta> Recetas { get; set; }

        // Tabla de operaciones
        public DbSet<Operacion> Operaciones { get; set; }

        // Tabla de fases
        public DbSet<Fase> Fases { get; set; }

        #endregion

        // Requerido por EntityFrameWork para migrar
        public ApplicationContext() { }

        // Inicializa un contexto de base de datos
        public ApplicationContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }

        // Inicializa un contexto de base de datos
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        // Para configurar detalles del contexto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Se utilizará Sqlite como RDBMS de nuestro contexto
            optionsBuilder.UseSqlite();
        }

        // Para configurar que tipo de dato va a cada tabla
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /* Definiendo la relación a través de una llave compuesta de 
               las acciones de control con sus respectivas fases*/
            modelBuilder.Entity<Fase>(builder =>
            {
                builder.HasKey(f => f.Id);

                builder.OwnsMany(f => f.AccionesDeControl, accionBuilder =>
                {
                    accionBuilder.WithOwner(a => a.Fase).HasForeignKey("FaseId");
                    accionBuilder.HasKey(a => new { a.AccionId, a.FaseId });
                });
            });
        }

        #region Helpers

        // Para obtener opciones del contexto a partir de un string de conexión
        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqliteDbContextOptionsBuilderExtensions.
                UseSqlite(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion
    }
}

