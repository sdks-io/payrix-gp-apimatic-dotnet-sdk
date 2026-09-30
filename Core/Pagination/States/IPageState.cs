using System.Net.Http.Headers;

namespace Payrix.Core.Pagination.States;

internal interface IPageState<in TResponse, out TState>
{
    TState? Next(TResponse page, HttpResponseHeaders headers);
}
