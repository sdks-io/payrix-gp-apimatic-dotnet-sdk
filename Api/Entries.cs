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
using Payrix.Requests.Entries;

namespace Payrix.Api;

/// <summary>
/// An entry record represents a credit or debit of funds for an entity, possibly part of a transfer of funds between two entities. Any monetary change for an entity in Payrix Pro is recorded in an entry. This serves as a ledger of financial activity for an entity.
/// </summary>
public sealed class Entries
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Entries(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getEntries
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Entry resource. An Entry resource represents a record of amounts moving in or out of the funds held by an Entity. This could be a time-based activity such as a weekly or monthly summary, or an event-based activity such as a Capture, a Payout, or a Fee. In the case of an event-based activity, the Entry contains references to the activity in the appropriate field.
    /// </remarks>
    public Task<EntriesResponseResult> GetEntries(GetEntriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entries"),
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
            JsonResponse.Create<EntriesResponseResult>(),
            GetEntriesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntriesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntriesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Entry resource.
    /// </remarks>
    public Task<EntriesResponseResult> GetEntriesId(GetEntriesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entries/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EntriesResponseResult>(),
            GetEntriesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
