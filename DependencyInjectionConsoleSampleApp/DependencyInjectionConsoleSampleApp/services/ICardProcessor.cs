using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionConsoleSampleApp.services
{
    public interface ICardProcessor
    {
       public string Connect(string address, int port);
    }
}
