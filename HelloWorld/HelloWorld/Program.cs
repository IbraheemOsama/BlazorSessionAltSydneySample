using HelloWorldServices;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.Add(ServiceDescriptor.Singleton<IDataAccess, DataAccess>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
