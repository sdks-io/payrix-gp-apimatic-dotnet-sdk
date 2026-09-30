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
using Payrix.Requests.TransactionMetadatas;

namespace Payrix.Api;

/// <summary>
/// Transaction Metadatas represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
/// </summary>
public sealed class TransactionMetadatas
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransactionMetadatas(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getTxnMetadatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnMetaDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnMetadatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a txnMetadatas resource.
    /// A txnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
    /// </remarks>
    public Task<TxnMetaDatasResponseResult> GetTxnMetadatas(GetTxnMetadatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnMetadatas"),
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
            JsonResponse.Create<TxnMetaDatasResponseResult>(),
            GetTxnMetadatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTxnMetadatasId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnMetaDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnMetadatasIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a txnMetadatas resource.
    /// A txnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.
    /// </remarks>
    public Task<TxnMetaDatasResponseResult> GetTxnMetadatasId(GetTxnMetadatasIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnMetadatas/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TxnMetaDatasResponseResult>(),
            GetTxnMetadatasIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
