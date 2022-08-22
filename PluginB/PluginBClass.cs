using PluginSDK;
using System;

namespace PluginB
{
    public class PluginBClass : IPlugin
    {

        public string Name { get => "PluginBTitle"; }
        public string Description { get => "This plugin B Description"; }

        public int GenerateReport(string reportname, string outlocation, string reportformate)
        {
            Console.WriteLine(string.Format("PluginB ->Report Generated from Template: {0} on Location: {1} formate:{2}", reportname, outlocation, reportformate));
            return 0;
        }
    }
}
