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
using Payrix.Requests.TerminalTransactionResults;

namespace Payrix.Api;

/// <summary>
/// Represents the result of a Transaction from a processor, which can be approved, declined, or raise an error.
/// </summary>
public sealed class TerminalTransactionResults
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalTransactionResults(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTerminalTxnResults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnResultsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Querying a terminalTxnResults resource represents the result of a Transaction from a processor, which can be approved, declined, or raise an error.
    /// </remarks>
    public Task<TerminalTxnResultsResponseResult> GetTerminalTxnResults(GetTerminalTxnResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnResults"),
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
            JsonResponse.Create<TerminalTxnResultsResponseResult>(),
            GetTerminalTxnResultsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalTxnResultsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnResultsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Querying a terminalTxnResults resource represents the result of a Transaction from a processor, which may be approved, declined, or raise an error.
    /// </remarks>
    public Task<TerminalTxnResultsResponseResult> GetTerminalTxnResultsId(GetTerminalTxnResultsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnResults/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalTxnResultsResponseResult>(),
            GetTerminalTxnResultsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
