using Autofac;
using DependencyInjectionConsoleSampleApp.DI;
using DependencyInjectionConsoleSampleApp.services;
using DependencyInjectionConsoleSampleApp.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DependencyInjectionConsoleSampleApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            // CreateBuilder();
            // await CreateBuilder(args);

            var builder = new ContainerBuilder();
            builder.RegisterType<CardProcessor>().As<ICardProcessor>();
            builder.RegisterType<Logger>().As<ILogger>();
            Container = builder.Build();

            ConnectToServer();

        }


        public static void ConnectToServer()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var network = scope.Resolve<ICardProcessor>();
                string result = network.Connect("www.google.com", 8080);
                Console.WriteLine(result);
            }
        }



        /*private static void CreateBuilder()
        {
            var container = DiContainer.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }*/

       /* private static async Task CreateBuilder(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            await builder.Build().RunAsync();
        }*/
    }
}
