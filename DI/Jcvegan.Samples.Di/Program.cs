using System;
using Microsoft.Extensions.DependencyInjection;
using Jcvegan.Samples.Di.Services;

namespace Jcvegan.Samples.Di
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            var serviceProvider = BuildProvider(serviceCollection);
            var greetingService = serviceProvider.GetRequiredService<IGreetingService>();
            Console.WriteLine(greetingService.SayHello("Juan"));
        }

        private static IServiceProvider BuildProvider(IServiceCollection services)
        {
            services.AddScoped<IGreetingService, GreetingService>();
            return services.BuildServiceProvider();
        }
    }
}
