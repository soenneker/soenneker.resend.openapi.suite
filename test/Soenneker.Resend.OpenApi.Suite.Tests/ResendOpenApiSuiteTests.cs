using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Resend.OpenApi.Suite.Tests;

[Collection("Collection")]
public sealed class ResendOpenApiSuiteTests : FixturedUnitTest
{
    public ResendOpenApiSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
