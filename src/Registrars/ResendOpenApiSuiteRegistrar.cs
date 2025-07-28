using Microsoft.Extensions.DependencyInjection;
using Soenneker.Resend.Emails.Registrars;

namespace Soenneker.Resend.OpenApi.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Resend's OpenApi operations
/// </summary>
public static class ResendOpenApiSuiteRegistrar
{
    public static IServiceCollection AddResendOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddResendOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddResendEmailsUtilAsScoped();

        return services;
    }
}
