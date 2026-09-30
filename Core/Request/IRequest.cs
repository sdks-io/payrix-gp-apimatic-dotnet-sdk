using System.Net.Http;

namespace Payrix.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}