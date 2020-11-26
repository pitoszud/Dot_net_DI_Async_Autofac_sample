using DependencyInjection.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Service
{
    public class NetworkService : INetworkService
    {

        ILogger _logger;

        public NetworkService(ILogger logger) => this._logger = logger;

        public void Connect()
        {
            _logger.Log("Starting network processing...");
            Console.WriteLine("Processing the data");
            _logger.Log("Finish network processing...");
        }

    }
}
