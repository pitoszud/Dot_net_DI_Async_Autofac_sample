using DependencyInjectionConsoleSampleApp.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionConsoleSampleApp
{
    class Application : IApplication
    {
        ICardProcessor _networkService;
        public Application(ICardProcessor networkService)
        {
            _networkService = networkService;
        }

        public void Run()
        {
            // _networkService.Connect();
        }
    }
}
