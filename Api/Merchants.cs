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
using Payrix.Requests.Merchants;

namespace Payrix.Api;

/// <summary>
/// Merchant details for transaction processing entities. Together with the entities table, this table defines a merchant. A merchant is primarily an entity that accepts payments and transacts with customers in Payrix Pro.
/// </summary>
public sealed class Merchants
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Merchants(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getMerchants
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Merchant, an organization that processes credit card payments, each associated with an Entity.
    /// </remarks>
    public Task<MerchantsResponseResult> GetMerchants(GetMerchantsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchants"),
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
            JsonResponse.Create<MerchantsResponseResult>(),
            GetMerchantsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMerchantsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Merchant, which is an organization that processes credit card payments and each is associated with an Entity.
    /// </remarks>
    public Task<MerchantsResponseResult> GetMerchantsId(GetMerchantsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchants/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MerchantsResponseResult>(),
            GetMerchantsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putMerchantsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutMerchantsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Merchant, A Merchant is an organization that processes credit card payments. Each Merchant is associated with an Entity.
    /// </remarks>
    public Task<MerchantsResponseResult> PutMerchantsId(PutMerchantsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchants/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MerchantsResponseResult>(),
            PutMerchantsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
