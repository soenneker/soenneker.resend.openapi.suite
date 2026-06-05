using Microsoft.Extensions.DependencyInjection;
using Soenneker.Resend.Emails.Registrars;

namespace Soenneker.Resend.OpenApi.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Resend's OpenApi operations
/// </summary>
public static class ResendOpenApiSuiteRegistrar
{
    /// <summary>
    /// Adds resend open api suite as singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddResendOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds resend open api suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddResendOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsScoped();

        return services;
    }
}
