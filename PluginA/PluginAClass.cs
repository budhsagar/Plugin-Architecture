using PluginSDK;
using System;

namespace PluginA
{
    public class PluginAClass : IPlugin
    {

        public string Name { get => "PluginATitle"; }
        public string Description { get => "This plugin A Description"; }

        public int GenerateReport(string reportname, string outlocation, string reportformate)
        {
            Console.WriteLine(string.Format("PluginA ->Report Generated from Template: {0} on Location: {1} formate:{2}", reportname, outlocation, reportformate));
            return 0;
        }
    }
}
