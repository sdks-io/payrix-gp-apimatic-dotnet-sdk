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
using Payrix.Requests.ChargebackMessages;

namespace Payrix.Api;

/// <summary>
/// Resources that deal with chargebacks. A chargeback is a dispute of a purchase that has already been charged to an account that can result in a return of funds.
/// </summary>
public sealed class ChargebackMessages
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChargebackMessages(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getChargebackMessages
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackMessagesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a chargebackMessage resource, which represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.
    /// </remarks>
    public Task<ChargebackMessagesResponseResult> GetChargebackMessages(GetChargebackMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackMessages"),
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
            JsonResponse.Create<ChargebackMessagesResponseResult>(),
            GetChargebackMessagesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChargebackMessagesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackMessagesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackMessagesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a chargebackMessage. A chargebackMessage resource represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.
    /// </remarks>
    public Task<ChargebackMessagesResponseResult> GetChargebackMessagesId(GetChargebackMessagesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackMessages/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargebackMessagesResponseResult>(),
            GetChargebackMessagesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postChargebackMessages
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackMessagesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostChargebackMessagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a chargebackMessage. A chargebackMessage resource represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.
    /// </remarks>
    public Task<ChargebackMessagesResponseResult> PostChargebackMessages(PostChargebackMessagesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackMessages"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ChargebackMessagesResponseResult>(),
            PostChargebackMessagesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
