using Microsoft.Extensions.DependencyInjection;
using ConsoleDIBluprint.Services;
using ConsoleDIBluprint.Models;
using ConsoleDIBluprint.Messaging;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.Extensions.Options;

namespace ConsoleDIBluprint.ServicesHelper
{
    public class ServicesGenerator
    {
        public static ServiceProvider GenerateServices(string[] args)
        {
            string settingsFolder = "Settings";

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Join(AppDomain.CurrentDomain.BaseDirectory, settingsFolder))
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appSettings.override.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            ServiceProvider serviceProvider = new ServiceCollection()

                // Add main services
                .AddTransient<ICalculator, Calculator>()
                .AddTransient<IBigBrain, BigBrain>()
                .AddTransient<IContextMessages, ContextMessages>()

                // Add settings
                .Configure<Settings>(configuration.GetSection("Settings"))
                .Configure<Error>(configuration.GetSection("Error"))

                // Build the services
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
