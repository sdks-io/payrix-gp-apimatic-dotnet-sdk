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
using Payrix.Requests.TerminalTransactions;

namespace Payrix.Api;

/// <summary>
/// Holds all of the information to a related final transaction and is used to reconcile with the actual, final transaction.
/// </summary>
public sealed class TerminalTransactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalTransactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteTerminalTxnsById
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTerminalTxnsByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a TerminalTxn that holds all of the information to a related final transaction and is used to be reconciled with that actual, final transaction.
    /// </remarks>
    public Task<TerminalTxnsResponseResult> DeleteTerminalTxnsById(DeleteTerminalTxnsByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxns/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalTxnsResponseResult>(),
            DeleteTerminalTxnsByIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalTxns
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TerminalTxn, which holds all of the information to a related final transaction and is used to reconcile with the actual, final transaction.
    /// </remarks>
    public Task<TerminalTxnsResponseResult> GetTerminalTxns(GetTerminalTxnsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxns"),
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
            JsonResponse.Create<TerminalTxnsResponseResult>(),
            GetTerminalTxnsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalTxnsById
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalTxnsByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TerminalTxn holds all of the information to a related final transaction, which they are used to be reconciled with that actual, final transaction.
    /// </remarks>
    public Task<TerminalTxnsResponseResult> GetTerminalTxnsById(GetTerminalTxnsByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxns/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalTxnsResponseResult>(),
            GetTerminalTxnsByIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTerminalTxns
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTerminalTxnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a TerminalTxn.
    /// TerminalTxns hold all of the information to a related final transaction. They are used to be reconcilliated with that actual, final transaction.
    /// </remarks>
    public Task<TerminalTxnsResponseResult> PostTerminalTxns(PostTerminalTxnsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxns"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalTxnsResponseResult>(),
            PostTerminalTxnsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// updateTerminalTxnsById
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateTerminalTxnsByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a TerminalTxn holds all of the information to a related final transaction and is used to be reconciled with that actual, final transaction.
    /// </remarks>
    public Task<TerminalTxnsResponseResult> UpdateTerminalTxnsById(UpdateTerminalTxnsByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxns/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalTxnsResponseResult>(),
            UpdateTerminalTxnsByIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
