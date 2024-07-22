using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HeaderFooter.Extensions;

public static class HeaderFooterExtensions
{

    public static IServiceCollection ConfigureHeaderFooterServices(this IServiceCollection services)
    {
        _ = services.AddTransient<IFooter, Footer>();
        _ = services.AddTransient<IHeader, Header>();

        return services;
    }

}
