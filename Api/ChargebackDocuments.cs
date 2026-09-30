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
using Payrix.Requests.ChargebackDocuments;

namespace Payrix.Api;

/// <summary>
/// Represents a file related to the Chargeback.
/// </summary>
public sealed class ChargebackDocuments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChargebackDocuments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteChargebackDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteChargebackDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.
    /// </remarks>
    public Task<ChargebackDocumentsResponseResult> DeleteChargebackDocumentsId(DeleteChargebackDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ChargebackDocumentsResponseResult>(),
            DeleteChargebackDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChargebackDocuments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query chargebackDocuments, each representing a file related to a Chargeback.
    /// </remarks>
    public Task<ChargebackDocumentsResponseResult> GetChargebackDocuments(GetChargebackDocumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackDocuments"),
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
            JsonResponse.Create<ChargebackDocumentsResponseResult>(),
            GetChargebackDocumentsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChargebackDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.
    /// </remarks>
    public Task<ChargebackDocumentsResponseResult> GetChargebackDocumentsId(GetChargebackDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargebackDocumentsResponseResult>(),
            GetChargebackDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postChargebackDocuments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostChargebackDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a chargebackDocument resource that represents a file related to a Chargeback.
    /// </remarks>
    public Task<ChargebackDocumentsResponseResult> PostChargebackDocuments(PostChargebackDocumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackDocuments"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ChargebackDocumentsResponseResult>(),
            PostChargebackDocumentsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putChargebackDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutChargebackDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.
    /// </remarks>
    public Task<ChargebackDocumentsResponseResult> PutChargebackDocumentsId(PutChargebackDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ChargebackDocumentsResponseResult>(),
            PutChargebackDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
