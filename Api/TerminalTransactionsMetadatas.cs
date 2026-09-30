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
using Payrix.Requests.TerminalTransactionsMetadatas;

namespace Payrix.Api;

/// <summary>
/// Terminal Transactions Metadatas Represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
/// </summary>
public sealed class TerminalTransactionsMetadatas
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalTransactionsMetadatas(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTerminalTxnsMetadatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnMetadatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsMetadatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a terminalTxnMetadatas resource.
    /// A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
    /// </remarks>
    public Task<TerminalTxnMetadatasResponseResult> GetTerminalTxnsMetadatas(GetTerminalTxnsMetadatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnMetadatas"),
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
            JsonResponse.Create<TerminalTxnMetadatasResponseResult>(),
            GetTerminalTxnsMetadatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalTxnsMetadatasId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnMetadatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsMetadatasIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a terminalTxnMetadatas resource.
    /// A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
    /// </remarks>
    public Task<TerminalTxnMetadatasResponseResult> GetTerminalTxnsMetadatasId(GetTerminalTxnsMetadatasIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnMetadatas/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalTxnMetadatasResponseResult>(),
            GetTerminalTxnsMetadatasIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTerminalTxnsMetadatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnMetadatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTerminalTxnsMetadatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a terminalTxnMetadatas resource. A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
    /// </remarks>
    public Task<TerminalTxnMetadatasResponseResult> PostTerminalTxnsMetadatas(PostTerminalTxnsMetadatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnMetadatas"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalTxnMetadatasResponseResult>(),
            PostTerminalTxnsMetadatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
