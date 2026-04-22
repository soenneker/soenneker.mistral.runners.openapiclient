using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mistral.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MistralOpenApiClientRunnerTests : HostedUnitTest
{
    public MistralOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
