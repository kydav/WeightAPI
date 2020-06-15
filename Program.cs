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
using WeightAPI.Contexts;

namespace WeightAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //logger.Info("Initializing application...");
                var host = CreateHostBuilder(args).Build();
                using (var scope = host.Services.CreateScope())
                {
                    try
                    {
                        var context = scope.ServiceProvider.GetService<WeightDBContext>();

                        //for demo purposes, delete the database & migrate on startup so
                        // we can start with a clean slate
                        context.Database.EnsureDeleted();
                        context.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        //logger.Error(ex, "An error occured while migrating the database");
                    }
                }

                host.Run();
            }
            catch (Exception ex)
            {
                //logger.Error(ex, "application stopped because of an e3xception.");
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
