using CoreServices.Runner.Interfaces;
using HeaderFooter.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CoreServices.Runner.Extensions;

public static class CoreServicesRunnerExtensions
{

    public static IServiceCollection ConfigureRunnerServices(this IServiceCollection services)
    {
        _ = services.ConfigureHeaderFooterServices();

        _ = services.AddTransient<IRunnableManager, RunnableManager>();

        return services;
    }

}
