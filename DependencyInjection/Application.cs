using DependencyInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Application : IApplication
    {
        INetworkService _networkService;
        public Application(INetworkService networkService)
        {
            _networkService = networkService;
        }

        public void Run()
        {
            _networkService.Connect();
        }
    }
}
