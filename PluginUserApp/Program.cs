using PluginSDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PluginUserApp
{
    class Program
    {

        static List<IPlugin> _plugins = null;
        static void Main(string[] args)
        {
            _plugins = ReadPlugins();
            Console.WriteLine(string.Format("Number of Plugin found :{0}", _plugins.Count));

            foreach (var plugin in _plugins)
            {
                Console.WriteLine(string.Format("Plugin Name: {0} Description: {1}", plugin.Name, plugin.Description));
                plugin.GenerateReport("SalaryReport from Plugins", "C:\\Report\\SalaryReport2022", "PDF");
               
            }



             Console.ReadLine();
        }

        static List<IPlugin> ReadPlugins()
        {
            var pluginsList = new List<IPlugin>();
            var files = Directory.GetFiles("Plugins", "*.dll");
            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(Path.Combine(Directory.GetCurrentDirectory(), file));
                var pluginTypes = assembly.GetTypes().Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface);
                foreach (var pluginType in pluginTypes)
                {
                    var pluginInstance = Activator.CreateInstance(pluginType) as IPlugin;
                    pluginsList.Add(pluginInstance);
                }

            }


            return pluginsList;
        }
    }
}
