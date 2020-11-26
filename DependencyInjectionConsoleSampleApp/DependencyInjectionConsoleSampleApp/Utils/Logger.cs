using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionConsoleSampleApp.Utils
{

    public class Logger : ILogger
    {
        public string currentMessage { get; set; }
        public void Log(string message)
        {
            this.currentMessage = message;
            Console.WriteLine($"Logging { message }");
        }
    }
}
