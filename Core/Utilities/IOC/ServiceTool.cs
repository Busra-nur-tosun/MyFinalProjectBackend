using Microsoft.Extensions.DependencyInjection;
using System;


namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        //Bu class’in amaci IoC (Inversion Of Control) yapimizi yönetmeyi saglayacaktir.

        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}