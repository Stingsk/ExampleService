using Autofac;

namespace ExampleService.DI.Modules;

public class ServiceModule: Module
{
    /// <summary>
    /// DI-модуль регистрации логики сервиса и вспомогательных класов
    /// </summary>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        RegisterExtractors(builder);
    }


    private void RegisterExtractors(ContainerBuilder builder)
    {
        //builder.RegisterType<HttpHeadersHelper>().As<IHttpHeadersHelper>();
    }

}