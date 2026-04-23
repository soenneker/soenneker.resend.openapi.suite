using Soenneker.Tests.HostedUnit;

namespace Soenneker.Resend.OpenApi.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ResendOpenApiSuiteTests : HostedUnitTest
{
    public ResendOpenApiSuiteTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
