using System;
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
using Payrix.Requests.TerminalTransactionsDatas;

namespace Payrix.Api;

/// <summary>
/// The terminal_txn_datas database table stores signature data for a terminal activation request. A terminalTxnData represents a signature image for a customer’s acceptance of terms and conditions for the resulting transaction.
/// </summary>
public sealed class TerminalTransactionsDatas
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalTransactionsDatas(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTerminalTxnsDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TerminalTxnData resource.
    /// </remarks>
    public Task<TerminalTxnDatasResponseResult> GetTerminalTxnsDatas(GetTerminalTxnsDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnDatas"),
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
            JsonResponse.Create<TerminalTxnDatasResponseResult>(),
            GetTerminalTxnsDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalTxnsDatasId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsDatasIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TerminalTxnData resource.
    /// </remarks>
    public Task<TerminalTxnDatasResponseResult> GetTerminalTxnsDatasId(GetTerminalTxnsDatasIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnDatas/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalTxnDatasResponseResult>(),
            GetTerminalTxnsDatasIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTerminalTxnsDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTerminalTxnsDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a TerminalTxnData resource.
    /// </remarks>
    public Task<TerminalTxnDatasResponseResult> PostTerminalTxnsDatas(PostTerminalTxnsDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnDatas"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalTxnDatasResponseResult>(),
            PostTerminalTxnsDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
