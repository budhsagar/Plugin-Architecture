using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSDK
{
  public  interface IPlugin
    {
        string Name { get; }
        string Description { get; }

       int GenerateReport(string reportname, string outlocation, string reportformate);
    }
}
