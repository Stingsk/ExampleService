using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using NLog;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace ExampleService
{
    /// <summary>
    ///
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var logger =  LogManager.GetCurrentClassLogger();

            try
            {
                logger.Debug("Старт приложения");
                Console.WriteLine(@"Старт приложения");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, $@"Ошибка при запуске приложения: {ex}");
                Console.WriteLine($@"Ошибка при запуске приложения: {ex}");
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        /// <summary>
        /// Создание хоста
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                        webBuilder.UseKestrel(opts =>
                        {
                            opts.ListenAnyIP(9393);
                        });
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Critical);
                })
                .UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}