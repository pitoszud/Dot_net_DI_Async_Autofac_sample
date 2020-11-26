using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DependencyInjection.About
{
    public partial class About: ComponentBase
    {
        public List<string> AboutList { get; set; }

        public About()
        {

            AboutList = new List<string>();
            this.AboutList.Add("Gym");
            this.AboutList.Add("Swimming");
            this.AboutList.Add("Running");
            this.AboutList.Add("Cycling");
        }

       
    }
}
