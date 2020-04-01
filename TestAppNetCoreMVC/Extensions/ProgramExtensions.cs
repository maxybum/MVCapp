using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TestAppNetCoreMVC.Data;

namespace TestAppNetCoreMVC.Extensions
{
    public static class ProgramExtensions
    {
        public static IHost ProcessDatabaseCommands(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                var logger = services.GetService<ILogger<ApplicationDbContext>>();
                logger. LogInformation($"{nameof(ApplicationDbContext)} migration");

                var context = services.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
            }

            return host;
        }
    }
}
