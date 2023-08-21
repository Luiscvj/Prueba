using Aplicacion.UnitOfWork;
using Dominio.Interfaces;
using iText.Kernel.XMP.Options;

namespace API.Extensions;

public static class ApplicationsServiceExtension
{
   
   public static void ConfigureCors(this IServiceCollection services)=>
            services.AddCors(Options => 
            Options.AddPolicy("CorsPolicy",builder=>
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()));

    public static void AddAplicationServices( this IServiceCollection services )
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}