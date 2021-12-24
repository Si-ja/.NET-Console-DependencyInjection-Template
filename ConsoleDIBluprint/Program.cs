using System;
using ConsoleDIBluprint.ServicesHelper;
using ConsoleDIBluprint.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDIBluprint
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Essential initial setup
            IServiceScope serviceScope = ServicesGenerator.GenerateServices(args).CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            // User defined code
            string action = "add";
            int a = 5, b = 10;
            IBigBrain bigBrain = serviceProvider.GetRequiredService<IBigBrain>();
            _ = bigBrain.InteractWithNumbers(a, b, action);
            _ = bigBrain.InteractWithNumbers(a, b, "Hello");
        }
    }
}
