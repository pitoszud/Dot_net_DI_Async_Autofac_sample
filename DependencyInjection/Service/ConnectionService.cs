using DependencyInjection.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Service
{
    public class ConnectionService : INetworkService
    {
        ILogger _logger;

        public ConnectionService(ILogger logger) => this._logger = logger;

        public void Connect()
        {
            _logger.Log("Starting connection processing...");
            Console.WriteLine("Processing the data");
            _logger.Log("Finish connection processing...");
        }
    }
}
