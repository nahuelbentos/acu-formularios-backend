using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistance;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();
            
            var hostServer = CreateHostBuilder(args).Build();

            using (var ambiente = hostServer.Services.CreateScope())
            {
                var services = ambiente.ServiceProvider;

                try
                {
                
                var context = services.GetRequiredService<FormularioContext>();
                context.Database.Migrate();

                }
                catch (Exception e)
                {
                var logging = services.GetRequiredService<ILogger<Program>>();
                logging.LogError(e, "Ocurrio un error en la migración");
                }

            }

            hostServer.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
