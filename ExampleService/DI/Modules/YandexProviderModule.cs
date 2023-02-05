using Autofac;
using Providers.Contracts;
using Providers.Yandex;
using Providers.Yandex.Mappers;
using Providers.Yandex.Services;

namespace ExampleService.DI.Modules;

public class YandexProviderModule : Module
{
    /// <summary>
    /// DI-модуль регистрации проапйдра яндекса
    /// </summary>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<YandexProvider>().Named<IProviderService>("yandex");
        RegisterYandexProvider(builder);
    }

    private void RegisterYandexProvider(ContainerBuilder builder)
    {
        builder.RegisterType<SearchService>().As<ISearchService>();
        builder.RegisterType<SearchRequestMapper>().SingleInstance();
        builder.RegisterType<SearchResponseMapper>().SingleInstance();
    }
}