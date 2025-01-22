using DatosDeConfiguracion.Application;
using DatosDeConfiguracion.Contracts;
using DatosDeConfiguracion.DataAccess;
using DatosDeConfiguracion.DataAccess.Contexts;
using DatosDeConfiguracion.DataAccess.Repositories.Entities;
using DatosDeConfiguracion.Services.Services;

namespace DatosDeConfiguracion.Services
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.AddMediatR(new MediatRServiceConfiguration()
            {
                AutoRegisterRequestProcessors = true,
            }
            .RegisterServicesFromAssemblies(typeof(AssemblyReference).Assembly));

            builder.Services.AddSingleton("Data Source=Data.sqlite");
            builder.Services.AddScoped<ApplicationContext>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
            builder.Services.AddScoped<IRecetaRepository, RecetaRepository>();
            builder.Services.AddScoped<IOperacionRepository, OperacionRepository>();
            builder.Services.AddScoped<IFaseRepository, FaseRepository>();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<ProductosService>();
            app.MapGrpcService<RecetasService>();
            app.MapGrpcService<OperacionesService>();
            app.MapGrpcService<FasesService>();

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}
    
        
            


