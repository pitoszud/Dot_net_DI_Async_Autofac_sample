using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Utils
{
    public interface ILogger
    {
        public void Log(string message);
    }
}
