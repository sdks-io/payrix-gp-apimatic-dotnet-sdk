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
using Payrix.Requests.TransactionsTxns;

namespace Payrix.Api;

/// <summary>
/// Resources for dealing with information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.
/// </summary>
public sealed class TransactionsTxns
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransactionsTxns(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTxns
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Transaction.
    /// Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.
    /// </remarks>
    public Task<TxnsResponseResult> GetTxns(GetTxnsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txns"),
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
            JsonResponse.Create<TxnsResponseResult>(),
            GetTxnsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTxnsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Transaction.
    /// Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.
    /// </remarks>
    public Task<TxnsResponseResult> GetTxnsId(GetTxnsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txns/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TxnsResponseResult>(),
            GetTxnsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTxns
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnsPostResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTxnsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Transaction.
    /// Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.
    /// </remarks>
    public Task<TxnsPostResponseResult> PostTxns(PostTxnsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txns"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TxnsPostResponseResult>(),
            PostTxnsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putTxnsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutTxnsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Transaction.
    /// Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.
    /// </remarks>
    public Task<TxnsResponseResult> PutTxnsId(PutTxnsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txns/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TxnsResponseResult>(),
            PutTxnsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
