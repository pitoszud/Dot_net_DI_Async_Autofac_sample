using DependencyInjectionConsoleSampleApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionConsoleSampleApp.services
{
    class CardProcessor: ICardProcessor
    {
        ILogger _logger;

        public CardProcessor(ILogger logger) => this._logger = logger;

        public string Connect(string address, int port)
        {
            _logger.Log("Start  processing...");

            return "processed";
        }
    }
}
