using Autofac;
using DependencyInjectionConsoleSampleApp.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using IContainer = Autofac.IContainer;

namespace DependencyInjectionConsoleSampleApp.DI
{
    public static class DiContainer
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register start application
            builder.RegisterType<Application>().As<IApplication>();

            // Manual registration
            builder.RegisterType<CardProcessor>().As<ICardProcessor>();
            //builder.RegisterType<ConnectionService>().As<INetworkService>();


            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjectionConsoleSampleApp)))
                .Where(t => t.Namespace.Contains("Utils"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));


            return builder.Build();


        }
    }
}
