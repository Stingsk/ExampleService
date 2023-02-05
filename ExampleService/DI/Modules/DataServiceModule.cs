using Autofac;
using ExampleService.Internal.Cache;
using ExampleService.Internal.Configuration;
using ExampleService.Internal.DataService;

namespace ExampleService.DI.Modules;

public class DataServiceModule: Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.Register(f => new RedisCacheProvider(f.Resolve<IConfigurationReader>())).As<ICacheProvider>().SingleInstance();
        builder.RegisterType<DataService>().As<IDataService>();
    }
}