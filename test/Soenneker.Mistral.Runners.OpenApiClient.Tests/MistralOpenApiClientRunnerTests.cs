using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mistral.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class MistralOpenApiClientRunnerTests : FixturedUnitTest
{
    public MistralOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
