using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Payrix.Core;
using Payrix.Core.Authentication;
using Payrix.Core.Exceptions;
using Payrix.Core.Models;
using Payrix.Core.Request;
using Payrix.Core.Response;
using Payrix.Errors;
using Payrix.Models;
using Payrix.Requests.PendingEntryApi;

namespace Payrix.Api;

/// <summary>
/// Pending Entry represents a record of amounts moving in or out of the funds held by an Entity.
/// </summary>
public sealed class PendingEntryApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PendingEntryApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getPendingEntries
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PendingEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPendingEntriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a PendingEntry resource.
    /// A PendingEntry resource represents a record of amounts moving in or out of the funds held by an Entity.
    /// For example, this could be a time-based activity such as a weekly or monthly summary, or an event-based activity such as a Capture, a Payout, or a Fee. In the case of an event-based activity, the PendingEntry contains references the activity in the appropriate field. Eventually the PendingEntry will trigger the creation of an Entry resource and its amount will reflect any unsourced amounts for the Entry.
    /// </remarks>
    public Task<PendingEntriesResponseResult> GetPendingEntries(GetPendingEntriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pendingEntries"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PendingEntriesResponseResult>(),
            GetPendingEntriesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPendingEntriesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PendingEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPendingEntriesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Pending Entry resource.
    /// </remarks>
    public Task<PendingEntriesResponseResult> GetPendingEntriesId(GetPendingEntriesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pendingEntries/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PendingEntriesResponseResult>(),
            GetPendingEntriesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
