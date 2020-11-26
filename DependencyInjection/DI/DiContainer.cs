using Autofac;
using DependencyInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DependencyInjection.DI
{
    public static class DiContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register start application
            builder.RegisterType<Application>().As<IApplication>();

            // Manual registration
            // builder.RegisterType<NetworkService>().As<INetworkService>();
            builder.RegisterType<ConnectionService>().As<INetworkService>();


            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjection)))
                .Where(t => t.Namespace.Contains("Utils"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            
            
            return builder.Build();

        
        }
    }
}
