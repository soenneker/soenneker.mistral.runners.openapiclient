using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Mistral.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
