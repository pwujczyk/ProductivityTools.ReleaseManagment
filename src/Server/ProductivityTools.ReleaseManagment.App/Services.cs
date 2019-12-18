using ProductivityTools.ReleaseManagment.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ProductivityTools.DateTimeTools;

namespace ProductivityTools.ReleaseManagment.App
{
    public static class Services
    {
        public static IServiceCollection ConfigureAppServices(this IServiceCollection services)
        {
            var connection = @"Data Source=.\sql2017;Initial Catalog=EcoVadisTM;Integrated Security=True";
            services.AddDbContext<EcoVadisTMContext>(options => options.UseSqlServer(connection), ServiceLifetime.Singleton);

            services.AddSingleton<IDictionary, Dictionary>();
            services.AddSingleton<IDateTimePT, DateTimePT>();
            return services;
        }
    }
}
