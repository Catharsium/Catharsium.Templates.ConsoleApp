using Catharsium.Util.Configuration.Extensions;
using Catharsium.Util.IO.Console._Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catharsium.Templates.ConsoleApp._Configuration
{
    public static class CatharsiumProjectClassNameRegistration
    {
        public static IServiceCollection AddCatharsiumProjectClassName(this IServiceCollection services, IConfiguration config)
        {
            var configuration = config.Load<CatharsiumProjectClassNameSettings>();
            services.AddSingleton<CatharsiumProjectClassNameSettings, CatharsiumProjectClassNameSettings>(provider => configuration);

            services.AddConsoleIoUtilities(config);

            //services.AddScoped<IActionHandler, ActivityListActionHandler>();

            return services;
        }
    }
}