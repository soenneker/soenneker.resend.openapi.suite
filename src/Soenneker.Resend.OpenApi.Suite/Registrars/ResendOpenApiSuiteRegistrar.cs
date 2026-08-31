using Microsoft.Extensions.DependencyInjection;
using Soenneker.Resend.Emails.Registrars;

namespace Soenneker.Resend.OpenApi.Suite.Registrars;

/// <summary>
/// Registers the Resend email operations included in this suite.
/// </summary>
public static class ResendOpenApiSuiteRegistrar
{
    /// <summary>
    /// Adds the included Resend email operations as singleton services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddResendOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds the included Resend email operations as scoped services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddResendOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsScoped();

        return services;
    }
}
