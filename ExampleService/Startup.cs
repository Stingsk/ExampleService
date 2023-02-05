using System.Net;
using Autofac;
using ExampleService.DI;
using ExampleService.Middleware;

namespace ExampleService;

    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Конфигурация AppSettings
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Startup
        /// </summary>
        public Startup()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
        }

        /// <summary>
        ///  ConfigureContainer is where you can register things directly
        ///  with Autofac. This runs after ConfigureServices so the things
        ///  here will override registrations made in ConfigureServices.
        ///  Don't build the container; that gets done for you by the factory.
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.Build(builder, Configuration);
        }

        /// <summary>
        /// ConfigureServices is where you register dependencies. This gets
        /// called by the runtime before the ConfigureContainer method, below.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Важно. Иначе не будет работать определение IP адреса. NLog и т.д.
            services.AddHttpContextAccessor();

            // Глобальный обрабочик неотловленных ошибок.
            services.AddMvc(o =>
            {
                o.Filters.Add<GlobalErrorHandler>();
            });

            services.AddHttpClient();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }