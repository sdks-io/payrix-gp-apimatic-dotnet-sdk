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
using Payrix.Requests.StatementEntry;

namespace Payrix.Api;

/// <summary>
/// Statement Entry represents a record of funds owed for a billing schedule.
/// </summary>
public sealed class StatementEntry
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal StatementEntry(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getStatementEntries
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StatementEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetStatementEntriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a StatementEntry resource.
    /// A StatementEntry resource represents a record of funds owed for a billing schedule.
    /// For example, this could be a scheduled weekly or monthly fee, or an event-based activity such as a capture or payout fee.
    /// </remarks>
    public Task<StatementEntriesResponseResult> GetStatementEntries(GetStatementEntriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/statementEntries"),
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
            JsonResponse.Create<StatementEntriesResponseResult>(),
            GetStatementEntriesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getStatementEntriesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StatementEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetStatementEntriesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a StatementEntry resource. A StatementEntry resource represents a record of funds owed for a billing schedule.
    /// </remarks>
    public Task<StatementEntriesResponseResult> GetStatementEntriesId(GetStatementEntriesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/statementEntries/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StatementEntriesResponseResult>(),
            GetStatementEntriesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
