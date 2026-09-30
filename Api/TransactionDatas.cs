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
using Payrix.Requests.TransactionDatas;

namespace Payrix.Api;

/// <summary>
/// Transactions Datas represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.
/// </summary>
public sealed class TransactionDatas
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransactionDatas(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTxnDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query txnDatas resource.
    /// A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.
    /// </remarks>
    public Task<TxnDatasResponseResult> GetTxnDatas(GetTxnDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnDatas"),
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
            JsonResponse.Create<TxnDatasResponseResult>(),
            GetTxnDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTxnDatasId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnDatasIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a txnDatas resource.
    /// A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.
    /// </remarks>
    public Task<TxnDatasResponseResult> GetTxnDatasId(GetTxnDatasIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnDatas/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TxnDatasResponseResult>(),
            GetTxnDatasIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTxnDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTxnDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a txnData. A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.
    /// </remarks>
    public Task<TxnDatasResponseResult> PostTxnDatas(PostTxnDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnDatas"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TxnDatasResponseResult>(),
            PostTxnDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
