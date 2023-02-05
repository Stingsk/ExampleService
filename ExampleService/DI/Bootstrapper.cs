using Autofac;
using ExampleService.DI.Modules;

namespace ExampleService.DI;

/// <summary>
/// Заполняет DI-контейнер по данным из модулей.
/// </summary>
public class Bootstrapper
{
    /// <summary>
    ///  Заполняет DI-контейнер по данным из модулей.
    /// </summary>
    /// <param name="builder">Контейнер</param>
    /// <param name="configuration">Конфигурация AppConfig</param>
    public void Build(ContainerBuilder builder, IConfiguration configuration)
    {
        builder.RegisterInstance(configuration).AsSelf();

        builder.RegisterModule<DataServiceModule>();
        builder.RegisterModule<ServiceModule>();
        builder.RegisterModule<YandexProviderModule>();
    }
}