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
using Payrix.Requests.EntityData;

namespace Payrix.Api;

/// <summary>
/// An entityData record is used to store a signature image for an entity's acceptance of terms and conditions.    This is stored in a separate table so as not to bloat the entities table with signature images that use a lot of space.    Additionally, the signatures are not included in API requests for the entities themselves, instead they are requested separately via the entityDatas resource.
/// </summary>
public sealed class EntityData
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EntityData(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getEntityDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntityDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an EntityDatas, which is the data related to an entity containing information about that entity such as the signature for the terms and conditions.
    /// </remarks>
    public Task<EntityDatasResponseResult> GetEntityDatas(GetEntityDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityDatas"),
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
            JsonResponse.Create<EntityDatasResponseResult>(),
            GetEntityDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntityDatasId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntityDatasIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an EntityDatas containing information about that entity, such as the signature for the terms and conditions.
    /// </remarks>
    public Task<EntityDatasResponseResult> GetEntityDatasId(GetEntityDatasIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityDatas/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EntityDatasResponseResult>(),
            GetEntityDatasIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postEntityDatas
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityDatasResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostEntityDatasError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an EntityDatas containing the data related to an entity, including information such as the signature for the terms and conditions.
    /// </remarks>
    public Task<EntityDatasResponseResult> PostEntityDatas(PostEntityDatasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityDatas"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EntityDatasResponseResult>(),
            PostEntityDatasError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
