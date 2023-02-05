using Autofac;
using ExampleService.Logic;
using ExampleService.Logic.Search;

namespace ExampleService.DI.Modules;

public class ServiceModule: Module
{
    /// <summary>
    /// DI-модуль регистрации логики сервиса и вспомогательных класов
    /// </summary>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        RegisterLogic(builder);
    }


    private void RegisterLogic(ContainerBuilder builder)
    {
        builder.RegisterType<SearchService>().As<ISearchService>();
        builder.RegisterType<TaxiManager>().As<ITaxiManager>();;
        builder.RegisterType<SearchRequestMapper>().SingleInstance();
        builder.RegisterType<SearchResponseMapper>().SingleInstance();
    }
}